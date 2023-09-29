using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblotek
{
    abstract internal class LibraryUser
    {
        private string _name;
        private int _id;

        public string Name
        { 
            get { return _name; }
            set { _name = value; }  
        }
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}
