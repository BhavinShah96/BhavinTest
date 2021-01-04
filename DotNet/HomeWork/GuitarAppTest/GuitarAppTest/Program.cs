using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuitarAppTest.Model;

namespace GuitarAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Guitar> myGuitar = new List<Guitar>();
            myGuitar.Add(new Guitar("A51468", "Fender", "stratocastor", 1569.56, "Electric", "Alder", "Alder"));
            myGuitar.Add(new Guitar("A58795", "Fender", "Bass Guitar", 1462.56, "Electric", "Alder", "Alder"));

            foreach (var i in myGuitar)
            {
                Console.WriteLine(i);
            }
            searchGuitar(myGuitar);
            
        }
        public static void searchGuitar(List<Guitar> guitar)
        {
            int n;


            Console.WriteLine("\nSearch Guitar By : ?");
            Console.WriteLine("\nPress 1 : SerialNo." + "\nPress 2 : Price" + "\nPress 3 : Builder" + "\nPress 4 : Model" +
                "\nPress 5 : Type" + "\nPress 6 : BackWood" + "\nPress 7 : TopWood");
            n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.Write("Enter SerialNo. : ");
                    string no = Convert.ToString(Console.ReadLine());
                    Console.WriteLine(no);
                    foreach (var g in guitar)
                    {
                        if (g.SerialNo == no)
                        {
                            PrintSearchInfo(g);
                        }
                    }
                    break;
                case 2:
                    Console.Write("Enter Price. : ");
                    string price = Convert.ToString(Console.ReadLine());
                    Console.WriteLine(no);
                    foreach (var g in guitar)
                    {
                        if (g.SerialNo == no)
                        {
                            PrintSearchInfo(g);
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Input...!!");
                    break;
            }
        }

        public static void PrintSearchInfo(Model.Guitar guitar)
        {
            Console.WriteLine("\nSerial No: " + guitar.SerialNo);
            Console.WriteLine("Price : " + guitar.Price);
            Console.WriteLine("Builder : " + guitar.Builder);
            Console.WriteLine("Model : " + guitar.Model);
            Console.WriteLine("Type : " + guitar.Type);
            Console.WriteLine("BackWood : " + guitar.BackWood);
            Console.WriteLine("TopWood : " + guitar.TopWood);
        }

    }
}
