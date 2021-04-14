using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToEmployeeCSV.Model;

namespace LinqToEmployeeCSV
{
    class Program
    {

        static void Main(string[] args)
        {
            var lines = File.ReadAllLines(@"C:\\Users\\NIKUNJ SHAH\\Desktop\\Employee.csv")
                .Select(x => x.Split(','))
                .Skip(1)
                .Select(x =>
                    new Employee
                    {
                        EmployeeId = int.Parse(x[0]),
                        EmployeeName = x[1],
                        Designation = x[2],
                        ManagerId = float.Parse(CheckNull(x[3])),
                        DateOfJoining = x[4],
                        Salary = double.Parse(x[5]),
                        Commission = double.Parse(CheckNull(x[6])),
                        Department = int.Parse(x[7])
                    });

            //LoadDepartments();
            Query2(lines);
            //Query3(lines);
            //Query4(lines);
        }

        private static String CheckNull(String data)
        {
            if (data.Equals("NULL") || data.Equals(""))
            {
                return "0";
            }
            return data;
        }

        
        public static void Query1(IEnumerable<Employee> data)
        {
            foreach (var line in data)
            {
                Console.WriteLine("\nEmp No =" + line.EmployeeId + ",Emp Name = " + line.EmployeeName + ", Designation = " + line.Designation
                   + ", ManagerID = " + line.ManagerId + ", DateOfJoining = " + line.DateOfJoining + ", Salary = " + line.Salary
                   + ", Commission = " + line.Commission + ", Department = " + line.Department);
            }
        }

        public static void Query2(IEnumerable<Employee> data)
        {
            var Employee = data.OrderByDescending(x => x.Salary).Take(3);
            foreach (var line in Employee)
            {
                Console.WriteLine("\nEmp No =" + line.EmployeeId + ",Emp Name = " + line.EmployeeName + ", Designation = " + line.Designation
                   + ", ManagerID = " + line.ManagerId + ", DateOfJoining = " + line.DateOfJoining + ", Salary = " + line.Salary
                   + ", Commission = " + line.Commission + ", Department = " + line.Department);
            }
        }
        public static void Query3(IEnumerable<Employee> data)
        {
            var Employee = data.Where(x => x.Salary > 2000 && x.Salary < 5000);
            foreach (var line in Employee)
            {
                Console.WriteLine("\nEmp No =" + line.EmployeeId + ",Emp Name = " + line.EmployeeName + ", Designation = " + line.Designation
                   + ", ManagerID = " + line.ManagerId + ", DateOfJoining = " + line.DateOfJoining + ", Salary = " + line.Salary
                   + ", Commission = " + line.Commission + ", Department = " + line.Department);
            }
        }

        public static void Query4(IEnumerable<Employee> data)
        {
            var Employee = data.Where(x => x.Designation == "CLERK");
            foreach (var line in Employee)
            {
                Console.WriteLine("\nEmp No =" + line.EmployeeId + ",Emp Name = " + line.EmployeeName + ", Designation = " + line.Designation
                   + ", ManagerID = " + line.ManagerId + ", DateOfJoining = " + line.DateOfJoining + ", Salary = " + line.Salary
                   + ", Commission = " + line.Commission + ", Department = " + line.Department);
            }
        }

        public static void Query5(IEnumerable<Employee> data)
        {
            var Employee = data.OrderBy(x => x.EmployeeName);
            foreach (var line in Employee)
            {
                Console.WriteLine("\nEmp No =" + line.EmployeeId + ",Emp Name = " + line.EmployeeName + ", Designation = " + line.Designation
                                   + ", ManagerID = " + line.ManagerId + ", DateOfJoining = " + line.DateOfJoining + ", Salary = " + ((line.Salary * 12) + (line.Commission * 12))
                                   + ", Commission = " + line.Commission + ", Department = " + line.Department);
            }
        }
    }
}
