using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblotek
{
    internal class Librarian : LibraryUser
    {
        private string _position;
        private List<Books> _libraryCollection;

        public Librarian(string name, int id, string position) 
        { 
            Position = position;
            _libraryCollection = new List<Books>(); 
        }
        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }
      
        public void AddBook(Books book)
        { 
            if (!_libraryCollection.Contains(book))
            { 
             _libraryCollection.Add(book);
                Console.WriteLine($"{book.Title} was added to the library");
            }
            else
            {
                Console.WriteLine($"{book.Title} is alreaddy in the library we dont need more.");
            }
        }
        public void RemoveBook(Books book)
        {
            if (_libraryCollection.Contains(book))
            { 
                _libraryCollection.Remove(book);
                Console.WriteLine($"{book.Title} have been removed from the library");
            }
            else 
            {
                Console.WriteLine($"{book.Title} couldnt be found in the library");
            }
        }
        public void SearchBook(Books findBook)
        {
            Console.WriteLine("What book are you looking for?");
             
            foreach (Books book in _libraryCollection)
            { 
                if (findBook.Title == book.Title || findBook.Isbn == book.Isbn || findBook.Author == book.Author) 
                {
                    Console.WriteLine($"{book.Title} is in the library ");
                }
                else
                {
                    Console.WriteLine($"{book.Title} couldnt be found in the library");
                }
            
            }
        }
        public void AddBookToShelf(Books book, Shelf shelf, string category)
        {
            if (shelf.Category == category)
            {
                shelf.BooksOnShelf.Add(book);
            }
            else 
            {
                Console.WriteLine($"The {book.Title} is alreaddy on the shelf");
            }
        }
        public void RemoveBookFromShelf(Books book, Shelf shelf)
        {
            if (shelf.BooksOnShelf.Contains(book))
            {
                shelf.BooksOnShelf.Remove(book);
            }
            else
            {
                Console.WriteLine($"{book.Title} couldnt be found on the shelf");
            }


        }
    }
}
