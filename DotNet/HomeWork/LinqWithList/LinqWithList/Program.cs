using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqWithList.Model;

namespace LinqWithList
{
    class Program
    {
        public static List<Employee> emp = new List<Employee>();
        static void Main(string[] args)
        {

            emp.Add(new Employee(1, "Bhavin", 50000));
            emp.Add(new Employee(2, "Akash", 42000));
            emp.Add(new Employee(3, "inder", 35000));
            emp.Add(new Employee(4, "Shahista", 40000));
            emp.Add(new Employee(5, "Parth", 59000));

            //Case1();
            //Case2();
            Case3();
        }

        public static void Case1()
        {
            var employee = emp.OrderByDescending(x => x._salary).Take(3);
            foreach(var i in employee)
            {
                Console.WriteLine(i._name);
            }
        }

        public static void Case2()
        {
            var employee = from e in emp where e._salary > 50000 select e;
            foreach (var i in employee)
            {
                Console.WriteLine(i._name);
            }
        }

        public static void Case3()
        {
            var employee = emp.Where(Employee => Employee._salary > 5000).ToList();
            employee.Add(new Employee(6,"Sanjay",49600));
            foreach (var i in employee)
            {
                Console.WriteLine("ID : " + i._id + " Name : " + i._name + " Salary : " + i._salary);
            }
        }

        //public static void Case4()
        //{
        //    var employee = emp.Where(Employee => Employee._salary > 5000);
        //    employee.Add(new Employee(6, "Sanjay", 49600));
        //    foreach (var i in employee)
        //    {
        //        Console.WriteLine("ID : " + i._id + " Name : " + i._name + " Salary : " + i._salary);
        //    }
        //}
    }
}
