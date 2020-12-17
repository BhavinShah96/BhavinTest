using EmployeeApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee p = new Programmer(1234,"Bhavin",25000,2500);

            Console.WriteLine("Employee ID is :" + p.Id);
            Console.WriteLine("Employee Name is :" + p.Name);
            Console.WriteLine("Employee Name is :" + p.Name);
        }
    }
}
