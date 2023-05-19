using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace FahasaApp
{
    internal static class Program
    {
        //Initate Global string connect for DataBase
        private static string strConn = "";
        public static MySettings mySettings = new MySettings();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
            initShopcart();
            Properties.Settings.Default.Save();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new NhanVienMainForm());
        }

        private static void initShopcart()
        {
            ShoppingCart cart = mySettings.shoppingCart;
            if (cart == null)
            {
                cart = new ShoppingCart();
            }
            mySettings.shoppingCart = cart;
            mySettings.Save();
        }

        public static string getConnectString()
        {
            return strConn;
        }

        //true to add book, false to remove book in shop cart
        public static void updateMySetting(Book book, bool flagUpdate)
        {
            ShoppingCart cart = mySettings.shoppingCart;
            if (flagUpdate)
                addBook(cart, book);
            else
                removeBook(cart, book);

        }
        //////////////////////////////////////
        public static int getCount()
        {
            List<Book> testBooks = mySettings.shoppingCart.getBookChose();
            return testBooks.Count;
        }
        public static string getQuantity()
        {
            List<Book> testBooks = mySettings.shoppingCart.getBookChose();
            return testBooks[0].getBookQuantity.ToString();
        }
        //////////////////////////////////////
        public static void addBook(ShoppingCart cart, Book book)
        {
            List<Book> books = cart.getBookChose();
            Book checkBook = books.Find(b => b.getBookID == book.getBookID);
            //Update quantity if user choose the same book more than twice
            if (checkBook  != null)
            {
                checkBook.setBookQuantity = checkBook.getBookQuantity + 1;
                cart.UpdateMultipleSameAdd(books);
            }
            else
            {
                cart.AddBook(book);
            }         
            mySettings.shoppingCart = cart;
            mySettings.Save();
        }
        public static void removeBook(ShoppingCart cart, Book book)
        {
            List<Book> books = cart.getBookChose();
            if(books.Count != 0)
            {
                Book bookToRemove = books.Find(b => b.getBookID == book.getBookID);
                books.Remove(bookToRemove);
                cart.UpdateMultipleSameAdd(books);
            }
            mySettings.shoppingCart = cart;
            mySettings.Save();
        }
        public static void refreshSettings()
        {
            ShoppingCart cart = new ShoppingCart();
            mySettings.shoppingCart = cart;
            mySettings.Save();
        }
    }
}
