using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollegeApp.Model;

namespace CollegeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<College> colleges = new List<College>();
            colleges.Add(new College(1001, "SOCET"));
            colleges.Add(new College(1002, "ASOIT"));

            List<Department> departments = new List<Department>();
            departments.Add(new Department(2001, "IT","SOCET"));
            departments.Add(new Department(2002, "COMPUTER","SOCET"));
            departments.Add(new Department(2003, "ELECTRICAL", "ASOIT"));
            departments.Add(new Department(2004, "BIOMEDICAL", "ASOIT"));

            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee(3001, "Parth","IT"));
            employees.Add(new Employee(3002, "Sahista","COMPUTER"));
            employees.Add(new Employee(3002, "Dhawani", "ELECTRICAL"));
            employees.Add(new Employee(3002, "Dhyey", "BIOMEDICAL"));

            List<Student> students = new List<Student>();
            students.Add(new Student(4001, "Bhavin"));
            students.Add(new Student(4002, "Inder"));
            
            PrintInfo(colleges,departments,employees,students);
        }

        public static void PrintInfo(List<College> colleges, List<Department> department,List<Employee> employees,List<Student> students)
        {
            Console.WriteLine(" College Information \n");

            foreach (var c in colleges)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine(" Department Information \n");
            foreach (var i in department)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine(" Employee Information \n");
            foreach (var i in employees)
            {
                Console.WriteLine(i);
            }
            

            Console.WriteLine(" Student Information \n");
            foreach (var i in students)
            {
                Console.WriteLine("Student Roll No." + i.getRollNo);
                Console.WriteLine("Student Name :" + i.getStudentName + "\n");
            }
            

        }

    }
}
