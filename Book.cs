using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Book : Document
    {
        //Fields 
        private int _isbn;
        private int _totalCopoies;
        private int _availbleCopies;

        //Propertys
        public int ISBN
        {
            get { return _isbn; }
            set { _isbn = value; }
        }

        public int TotalCopoies
        {
            get { return _totalCopoies;}
            set { _totalCopoies = value;}
        }

        public int AvailbleCopies
        {
            get { return _availbleCopies; }
            set { _availbleCopies = value;}
        }

        


    }
}
