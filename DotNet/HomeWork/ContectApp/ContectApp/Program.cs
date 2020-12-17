using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContectApp.Model;

namespace ContactApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AddPerson();
            ListContacts();
            ModifyContect();
            //RemoveContacts();
            ListContacts();
        }
        public static List<Contect> Contacts = new List<Contect>();

        public static void AddPerson()
        {
            Contect c = new Contect();

            string ph = Convert.ToString(c.phoneNo);

            Console.WriteLine("Enter First Name : ");
            c.fname = Console.ReadLine();

            Console.WriteLine("Enter Last Name : ");
            c.lname = Console.ReadLine();

            Console.WriteLine("Enter PhoneNo. : ");
            c.phoneNo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Email");
            c.email = Console.ReadLine();

            Contacts.Add(c);
            int n;
            Console.WriteLine("Select any option : \n 1 - Add New Contect \n 2 - Exit \n ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 1)
            {
                AddPerson();
            }
            else
            {
                return;
            }

        }

        public static void PrintInfo(Contect c)
        {
            Console.WriteLine("FirstName : " + c.fname);
            Console.WriteLine("LirstName : " + c.lname);
            Console.WriteLine("PhoneNo. : " + c.phoneNo);
            Console.WriteLine("Email : " + c.email);
        }

        public static void ListContacts()
        {
            if (Contacts.Count == 0)
            {
                Console.WriteLine("Your PhoneBook is Empty");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Here are the current Contacts in your PhoneBook\n");

            foreach (var contact in Contacts)
            {

                PrintInfo(contact);
            }
        }

        public static void RemoveContacts()
        {
            Console.WriteLine("Enter the FirstName of the Contact you want to remove : ");
            string fName = Console.ReadLine();
            Contect c = Contacts.FirstOrDefault(x => x.fname.ToLower() == fName.ToLower());

            if (Contacts == null)
            {
                Console.WriteLine("That Contact could not be found");
                return;
            }

            Console.WriteLine("Are you Sure you want to remove this Contact ? (Y/N)");
            PrintInfo(c);

            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Contacts.Remove(c);
                Console.WriteLine("Contact Removed...");
            }
        }

        public static void ModifyContect()
        {
            Console.WriteLine("Enter the FirstName of the Contact you want to Modify : ");
            string fName = Console.ReadLine();
            Contect c = Contacts.FirstOrDefault(x => x.fname.ToLower() == fName.ToLower());
            if (Contacts == null)
            {
                Console.WriteLine("That Contact could not be found");
                return;
            }
            Console.WriteLine("Are you Sure you want to Modify this Contact ? (Y/N)");
            PrintInfo(c);

            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                int n;
                Console.WriteLine("Select which detail to modify : \n 1 - Firstname \n 2 - LastName \n 3 - Phone No. \n 4 - E-mail ");
                n = Convert.ToInt32(Console.ReadLine());

                switch (n)
                {
                    case 1:

                        Console.WriteLine("Add the Name You Want to Replace");
                        c.fname = Console.ReadLine();
                        c.fname = c.fname;
                        PrintInfo(c);
                        break;
                    case 2:

                        Console.WriteLine("Add the last Name You Want to Replace");
                        c.lname = Console.ReadLine();
                        c.lname = c.lname;
                        PrintInfo(c);
                        break;
                    case 3:

                        Console.WriteLine("Add the Number You Want to Replace");
                        c.phoneNo = Convert.ToDouble(Console.ReadLine());
                        c.phoneNo = c.phoneNo;
                        PrintInfo(c);
                        break;
                    case 4:

                        Console.WriteLine("Add the email You Want to Replace");
                        c.email = Console.ReadLine();
                        c.email = c.email;
                        PrintInfo(c);
                        break;
                    default:
                        Console.WriteLine("Invalid !!");
                        break;
                }

            }
        }
    }
}
