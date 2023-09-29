using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblotek
{
    internal class Shelf
    {
        private int _id;
        private string _category;
        private List <Books> _booksOnShelf;
        public Shelf(int id, string category) 
        { 
            ID = id;
            Category = category;
            _booksOnShelf = new List <Books>();
        }
        public int ID 
        { 
            get { return _id; } 
            set { _id = value; }
        }
        public string Category
        { 
            get { return _category; } 
            set {  _category = value; } 
        }
        public List<Books> BooksOnShelf
        { 
            get { return _booksOnShelf; } 
            set { _booksOnShelf = value; }  
        }
    }
}
