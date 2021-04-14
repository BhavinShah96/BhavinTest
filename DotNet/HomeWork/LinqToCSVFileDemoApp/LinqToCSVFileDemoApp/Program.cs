using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToCSVFileDemoApp.Model;
using System.IO;
using System.Globalization;
using CsvHelper;

namespace LinqToCSVFileDemoApp
{
    class Program
    {
        public static IEnumerable<DEPT> department;
        static void Main(string[] args)
        {
            LoadFromDepartment();

        }

        public static IEnumerable<DEPT> LoadFromDepartment()
        {

            var Lines = File.ReadAllLines(@"C:\\Users\\NIKUNJ SHAH\\Desktop\\DEPT.csv").Select(x => x.Split(',')).Skip(0)
            .Select(x => new DEPT
            {
                DEPTNO = int.Parse(x[0]),
                DEPTNAME = x[1],
                LOCATION = x[2]
            });

            foreach (var i in Lines)
            {
                Console.WriteLine("Department No : " + i.DEPTNO + " Department Name : " + i.DEPTNAME + " Location : " + i.LOCATION);
            }
            return Lines;
        }
    }
}
