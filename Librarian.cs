using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Librarian : LibraryUser
    {
        // Fields
        private string _position;

        public Librarian(int id, string name, string position) : base(id, name)
        {
            _position = position;
        }
       

        public string Posistion
        {
            get { return _position; }
            set { _position = value; }
        }

     
        public void AddBook(Member member, Book book)
        {
            member._checkedOutBooks.Add(book);


        }

        public void RemoveBook()
        {

        }

        public void SearchBook()
        {

        }

    }


    

}
