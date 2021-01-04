using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryBookApp.Model;

namespace LibraryBookApp
{
    class Program 
    {
        static void Main(string[] args)
        {
            List<Library> library = new List<Library>();
            library.Add(new Library(1, Model.LibraryEnum.SOCET.ToString()));
            library.Add(new Library(1, Model.LibraryEnum.ASOIT.ToString()));

            List<Book> book = new List<Book>();
            book.Add(new Book(1001,"ABC","Bhavin Shah",2500, Model.LibraryEnum.ASOIT.ToString()));
            book.Add(new Book(1001, "DEF", "Sachin Shah", 2000, Model.LibraryEnum.ASOIT.ToString()));
            book.Add(new Book(1001, "GHI", "RAvin Shah", 3000, Model.LibraryEnum.SOCET.ToString()));
            book.Add(new Book(1001, "NPQ", "Saurav Shah", 3500, Model.LibraryEnum.SOCET.ToString()));

            PrintInfo(library, book);
        }

        public static void PrintInfo(List<Library> library , List<Book> book)
        {
            Console.WriteLine("Library Info : \n");
            foreach(var i in library)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nBook Info :");
            foreach(var i in book)
            {
                Console.WriteLine(i);
            }
        }
    }
}
