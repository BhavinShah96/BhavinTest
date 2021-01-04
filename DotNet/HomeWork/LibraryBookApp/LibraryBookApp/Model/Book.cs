using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBookApp.Model
{
    class Book : Library
    {
        private int _Code;
        private string _Name;
        private string _Author;
        private int _Price;
        private string _LibraryName;

        public int Code { get => _Code; }
        public string Name { get => _Name; }
        public string Author { get => _Author; set => _Author = value; }
        public int Price { get => _Price; set => _Price = value; }
        public string LibraryName { get => _LibraryName; }

        public Book(int code, string name, string author, int price, string libraryName) : base(code, name)
        {
            _Code = code;
            _Name = name;
            _Author = author;
            _Price = price;
            _LibraryName = libraryName;
        }
        public override string ToString()
        {
            return "\nBook Code :" + _Code + "\nBook Name :" + _Name + "\nBook Author :" + _Author +
                "\nBook Price :" + _Price + "\nLibrary Name :" + _LibraryName + "\n";
        }
    }
}
