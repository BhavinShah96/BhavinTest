using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentProfessorDemoApp.Model;

namespace StudentProfessorDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Model.student s = new Model.student(1, "Kalupur", new DateTime(199, 03, 13), Model.Branch.COMP);
            PrintInfo(s);
            Model.Professor p = new Model.Professor(101, "Andheri", new DateTime(1993, 05, 17), 15000);
            PrintInfo(p);
        }
        private static void PrintInfo(Model.Person person)
        {
            Console.WriteLine("\n ID : " + person.Id);
            Console.WriteLine("Address : " + person.Address);
            Console.WriteLine("Date of Birth : " +person.DateOfBirth);

            if(person is student)
            {
                student s = (student)person;
                Console.WriteLine("Branch :" + s.Branch);
            }
            else if(person is Professor)
            {
                Professor p = (Professor)person;
                Console.WriteLine("Basic pay :" + p.BasicSalary);
                Console.WriteLine("Total Salary : " + p.GrossSalary);

            }
            else
            {
                Console.WriteLine("No more information found");
            }
        }
    }
}
