using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblotek
{
    internal class Transaction
    {
     
        private int _transactionid;
        private string _book;
        private string _member;
        private DateTime _issuedate;
        private DateTime _returndate;

        public int TransactionID { get { return _transactionid; } set { _transactionid = value; } }
        public string Book { get { return _book; } set { _book = value; } }
        public string Member { get { return _member;} set { _member = value; } }
        public DateTime IssueDate { get { return _issuedate; } set { _issuedate = value; } }
        public DateTime ReturnDate { get { return _returndate;} set { _returndate = value; } }
       

        public double CalculateOverdueFees(DateTime loan)
        {
            IssueDate = loan;
            if (IssueDate > _returndate)
            { 
                TimeSpan date = _returndate.Subtract(_issuedate);
                double overdueDays = date.TotalDays;
                if (overdueDays > 30)
                {
                    double extraDays = overdueDays - 30;
                    double FeeToPay = extraDays * 10;
                    return FeeToPay;
                }
            }
            return 0;
        }
    }
}
