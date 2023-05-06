using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahasaApp
{
    public class Book
    {
        private int BookID;
        private byte[] BookImage;
        private string BookTitle;
        private string BookCover;
        private string BookCategory;
        private string BookPrice;
        private string PublicationDate;
        private string Publisher;
        private string Author;
        private int BookQuantity = 1;

        //Constructor
        public Book(int bookID,string bookTitle, string bookCover, string bookCategory, string bookPrice, string publicationDate, string publisher, string author, byte[] bookImage)
        {
            this.BookID = bookID;
            this.BookTitle = bookTitle;
            this.BookCover = bookCover;
            this.BookCategory = bookCategory;
            this.BookPrice= bookPrice;
            this.PublicationDate = publicationDate;
            this.Publisher = publisher;
            this.Author = author;
            this.BookImage = bookImage;
        }

        public int getBookID
        {
            get { return this.BookID; }
        }
        public int setBookID
        {
            set { this.BookID = value; }
        }
        public string getBookTitle
        {
            get { return this.BookTitle; }        
        }
        public string setBookTitle
        {
            set { this.BookTitle = value; }
        }
        public string getBookCover
        {
            get { return this.BookCover; }
        }
        public string setBookCover
        {
            set { this.BookCover = value; }
        }
        public string getBookCategory
        {
            get { return this.BookCategory; }
        }
        public string setBookCategory
        {
            set { this.BookCategory = value; }
        }
        public string getPublisher
        {
            get { return this.Publisher; }
        }
        public string setPublisher
        {
            set { this.Publisher = value; }
        }
        public string getAuthor
        {
            get { return this.Author; }
        }
        public string setAuthor
        {
            set { this.Author = value; }
        }
        public string getPublicationDate
        {
            get { return this.PublicationDate; }
        }
        public string setPublicationDate
        {
            set { this.PublicationDate = value; }
        }
        public byte[] getBookImage 
        { 
            get { return this.BookImage; } 
        }
        public string getBookPrice
        {
            get { return this.BookPrice; }
        }
        public string setBookPrice
        {
            set { this.BookPrice = value; }
        }
        public int getBookQuantity
        {
            get { return this.BookQuantity; }
        }
        public int setBookQuantity
        {
            set { this.BookQuantity = value; }
        }

    }
}

