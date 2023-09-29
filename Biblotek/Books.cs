using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Biblotek
{
    internal class Books
    {
        private string _title;
        private string _author;
        private long _isbn;
        private int _totalcopies;
        private int _availiablecopies;

        public Books(string title, string author, long isbn, int totalcopies, int availablecopies) 
        { 
            Title = title;
            Author = author;
            Isbn = isbn;
            Totalcopies = totalcopies;
            Availablecopies = availablecopies;
        }
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string Author
        { 
            get { return _author; } 
            set { _author = value; }    
        }
        public long Isbn
        { 
            get { return _isbn; }
            set { _isbn = value; }
        }
        public int Totalcopies
        { 
            get { return _totalcopies; }
            set { _totalcopies = value; }
        }
        public int Availablecopies
        {
            get { return _availiablecopies; }
            set { _availiablecopies = value; }
        }
    }
}
