using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContectApp.Model;
using System.Data.SqlClient;

namespace ContactApp
{
    class Program
    {
        static string connectionString = "Data Source = 192.168.1.2;Initial Catalog=BhavinTest;User Id=sa;Password=passw0rd!;";
        static SqlConnection con = new SqlConnection(connectionString);
        static void Main(string[] args)
        {
            try
            {
                con.Open();
                Console.WriteLine("Connection Successfull...!\nConnection String is : " + con.ConnectionString);
                Console.WriteLine("Connection TimeOut : " + con.ConnectionTimeout);
                Console.WriteLine("Connected Database is : " + con.Database);
                AddPerson();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }
            
            //ListContacts();
            //ModifyContect();
            ////RemoveContacts();
            //ListContacts();
        }
        public static List<Contect> Contacts = new List<Contect>();

        public static void AddPerson()
        {

            Console.WriteLine("Case 1 :\n");
            string queryString = "Select * from PhoneBook";
            SqlCommand cmd = new SqlCommand(queryString, con);
            Console.WriteLine("PhoneID\tName\tNumber\tAddress\tEmail");
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine(string.Format("{0}\t{1}\t{2}\t{3}\t{4}",reader[0],reader[1],reader[2],reader[3],reader[4]));
                }
            }

        //    Contect c = new Contect();

        //    Console.WriteLine("Enter Name : ");
        //    c.Name = Console.ReadLine();

        //    Console.WriteLine("Enter Phone no : ");
        //    c.PhoneNo = Console.ReadLine();

        //    Console.WriteLine("Enter Email. : ");
        //    c.email = Console.ReadLine();

        //    Console.WriteLine("Enter Address");
        //    c.Address = Console.ReadLine();

        //    //Contacts.Add(c);


        //    string queryString1 = "Insert into PhoneBook values (" + c.Name + ',' + c.PhoneNo + ',' + c.email + ',' + c.Address + ");
        //    SqlCommand cmd1 = new SqlCommand(queryString1, con);
        //    Console.WriteLine("PhoneID\tName\tNumber\tAddress\tEmail");
        //    using (SqlDataReader reader = cmd1.ExecuteReader())
        //    {
        //        while (reader.Read())
        //        {
        //            Console.WriteLine(string.Format("{0}\t{1}\t{2}\t{3}\t{4}", reader[0], reader[1], reader[2], reader[3], reader[4]));
        //        }
        //    }



        //    int n;
        //    Console.WriteLine("Select any option : \n 1 - Add New Contect \n 2 - Exit \n ");
        //    n = Convert.ToInt32(Console.ReadLine());

        //    if (n == 1)
        //    {
        //        AddPerson();
        //    }
        //    else
        //    {
        //        return;
        //    }

        //}

        public static void PrintInfo(Contect c)
        {
            Console.WriteLine("FirstName : " + c.fname);
            Console.WriteLine("LirstName : " + c.lname);
            Console.WriteLine("PhoneNo. : " + c.phoneNo);
            Console.WriteLine("Email : " + c.email);
        }

        //public static void ListContacts()
        //{
        //    if (Contacts.Count == 0)
        //    {
        //        Console.WriteLine("Your PhoneBook is Empty");
        //        Console.ReadKey();
        //        return;
        //    }
        //    Console.WriteLine("Here are the current Contacts in your PhoneBook\n");

        //    foreach (var contact in Contacts)
        //    {

        //        PrintInfo(contact);
        //    }
        //}

        //public static void RemoveContacts()
        //{
        //    Console.WriteLine("Enter the FirstName of the Contact you want to remove : ");
        //    string fName = Console.ReadLine();
        //    Contect c = Contacts.FirstOrDefault(x => x.fname.ToLower() == fName.ToLower());

        //    if (Contacts == null)
        //    {
        //        Console.WriteLine("That Contact could not be found");
        //        return;
        //    }

        //    Console.WriteLine("Are you Sure you want to remove this Contact ? (Y/N)");
        //    PrintInfo(c);

        //    if (Console.ReadKey().Key == ConsoleKey.Y)
        //    {
        //        Contacts.Remove(c);
        //        Console.WriteLine("Contact Removed...");
        //    }
        //}

        //public static void ModifyContect()
        //{
        //    Console.WriteLine("Enter the FirstName of the Contact you want to Modify : ");
        //    string fName = Console.ReadLine();
        //    Contect c = Contacts.FirstOrDefault(x => x.fname.ToLower() == fName.ToLower());
        //    if (Contacts == null)
        //    {
        //        Console.WriteLine("That Contact could not be found");
        //        return;
        //    }
        //    Console.WriteLine("Are you Sure you want to Modify this Contact ? (Y/N)");
        //    PrintInfo(c);

        //    if (Console.ReadKey().Key == ConsoleKey.Y)
        //    {
        //        int n;
        //        Console.WriteLine("Select which detail to modify : \n 1 - Firstname \n 2 - LastName \n 3 - Phone No. \n 4 - E-mail ");
        //        n = Convert.ToInt32(Console.ReadLine());

        //        switch (n)
        //        {
        //            case 1:

        //                Console.WriteLine("Add the Name You Want to Replace");
        //                c.fname = Console.ReadLine();
        //                c.fname = c.fname;
        //                PrintInfo(c);
        //                break;
        //            case 2:

        //                Console.WriteLine("Add the last Name You Want to Replace");
        //                c.lname = Console.ReadLine();
        //                c.lname = c.lname;
        //                PrintInfo(c);
        //                break;
        //            case 3:

        //                Console.WriteLine("Add the Number You Want to Replace");
        //                c.phoneNo = Convert.ToDouble(Console.ReadLine());
        //                c.phoneNo = c.phoneNo;
        //                PrintInfo(c);
        //                break;
        //            case 4:

        //                Console.WriteLine("Add the email You Want to Replace");
        //                c.email = Console.ReadLine();
        //                c.email = c.email;
        //                PrintInfo(c);
        //                break;
        //            default:
        //                Console.WriteLine("Invalid !!");
        //                break;
        //        }

        //    }
        //}
    }
}
