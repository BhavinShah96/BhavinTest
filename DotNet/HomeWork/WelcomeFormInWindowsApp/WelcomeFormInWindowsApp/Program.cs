using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace WelcomeFormInWindowsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            WelcomeForm welcome = new WelcomeForm();
            //Case1(welcome);
            Case2(welcome);
            //Case3(welcome);
            Application.Run(welcome);
        }


        public static void Case1(WelcomeForm welcome)
        {
            Console.WriteLine("\nCase 1 : \n");
            welcome.Load += log;
        }

        public static void Case2(WelcomeForm welcome)
        {
            welcome.Load += delegate (Object sender, EventArgs e)
            {
                
                Console.WriteLine("\nCase 2 : \n");
                Console.WriteLine("Insede Anonymous Function.");
                Console.WriteLine("Writing to text file.");
                
            };
        }

        public static void Case3(WelcomeForm welcome)
        {
            welcome.Load += (sender, e) =>
            {
                Console.WriteLine("\nCase 3 : \n");
                Console.WriteLine("Inside Lambda Function");
                Console.WriteLine("Writing to text file.");
            };
            
        }

        public static void log(Object sender, EventArgs e)
        {
            string path = @"C:\Users\NIKUNJ SHAH\Desktop\Hello.txt";
            File.WriteAllText(path, "Writing to first File using event");
            Console.WriteLine("I am Learning Windows Form Inside a File.");
        }
    }
}
