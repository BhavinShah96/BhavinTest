using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBookApp.Model
{
    class Library
    {
        private int _Code;
        private string _LibraryName;

        public int LibraryCode { get => _Code; }
        public string LibreryName { get => _LibraryName;}

        public Library(int code, string name)
        {
            _Code = code;
            _LibraryName = name;
        }
        public override string ToString()
        {
            return "\nLibrary Code :" + _Code + "\nLibrary Name :" + _LibraryName;
        }
    }
}
