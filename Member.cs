using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Member : LibraryUser
    {
        private string _adress;
        private double _overdueFees;
        public List<Book> _checkedOutBooks;

        public Member(int id, string name, string adress, double overdueFees) : base(id, name)
        {
            _adress = adress;
            _overdueFees = overdueFees;
            _checkedOutBooks = new List<Book>();
        }

        public string Adress
        { 
            get { return _adress;}
            set { _adress = value;}
        }

        public double OverdueFees
        {
            get { return _overdueFees;}
            set { _overdueFees = value;}
        }

        public void ViewTransactionHistory()
        {

        }

        

                   

    }
}
