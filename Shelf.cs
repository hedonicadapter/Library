using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Shelf
    {
        private string ID { get; set; }
        private string Category { get; set; } 
        private List<Book>  ListofBooks { get; set; }
        public Shelf(string _ID, string _Category,List<Book> _ListofBooks )
        {
         ID = _ID; 
         Category = _Category;
         ListofBooks = _ListofBooks;
        }

        public void AddBookToShelf(Book book) {}
        public void RemoveBookFromShelf(Book book) {}
        public void ShelfIsFull () {}


    }

}
