using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahasaApp
{
    public  class ShoppingCart
    {
        public  List<Book> books;
        public int test = 1;
        public ShoppingCart()
        {
            books = new List<Book>();
        }
        public int testing()
        {
            return  test;
        }
        public void AddBook(Book book)
        {
            this.books.Add(book);
        }
        public List<Book> getBookChose()
        {
            return books;
        }
        public void UpdateMultipleSameAdd(List<Book> Allbooks)
        {
            this.books = Allbooks;
        }
    }
}
