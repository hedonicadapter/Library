using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Transaction
    {
        //Propertys
        public string TransactionId;
        public string Book;
        public string Member;
        public int IssueDate;
        public int ReturnDate;

        //Construktor
        public Transaction(string transactionId, string book, string member, int issueDate, int returnDate)
        {
            TransactionId = transactionId;
            Book = book;
            Member = member;
            IssueDate = issueDate;
            ReturnDate = returnDate;
        }

        //Metoder
        public double CalculateOverDueFees()
        {
            return = 0; 
        }
    }
}
