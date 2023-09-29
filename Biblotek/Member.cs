using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblotek
{
    internal class Member : LibraryUser
    {
        private string _adress;
        private double _overduefees;
        private List <Books> _checkedoutbooks;
        Transaction transaction;

        public Member(string name, int id, string adress, double overduefees) 
        { 
            Name = name;
            ID = id;
            Adress = adress;
            OverdueFees = overduefees;
            CheckedOutBooks = new List<Books>();
            transaction = new Transaction();
        }
        public string Adress
        { 
            get { return _adress; }
            set { _adress = value; }
        }
        public double OverdueFees
        {
            get { return  _overduefees; }
            set { _overduefees = value; }
        }
        public List<Books> CheckedOutBooks
        {
            get { return _checkedoutbooks; }
            set { _checkedoutbooks = value; }
        }
        public void CheckOutBook(Books book)
        {
            CheckedOutBooks.Add(book);
            book.Availablecopies -= 1;
            Console.WriteLine($"You have borrowed {book.Title}");
        }
        public void ReturnBook(Books book)
        {
            Console.WriteLine("Enter date of the loan");
            DateTime timeOfLoan = Convert.ToDateTime(Console.ReadLine());
            OverDuefeeUppdater(timeOfLoan);
            CheckedOutBooks.Remove(book);
            book.Availablecopies += 1;
            Console.WriteLine($"You have returned {book.Title}");
        }
        public void OverDuefeeUppdater(DateTime loan)
        {
            double LateFee = transaction.CalculateOverdueFees(loan);
            _overduefees += LateFee;
            Console.WriteLine($"Overdue Fee: {OverdueFees}");
        }

    }
}
