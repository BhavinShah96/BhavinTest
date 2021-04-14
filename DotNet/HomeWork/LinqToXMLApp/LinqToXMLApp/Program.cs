using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqToXMLApp
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement xelement = XElement.Load("C:\\Users\\NIKUNJ SHAH\\Desktop\\Employee.xml");
            IEnumerable<XElement> employees = xelement.Elements();
            // Read the entire XML
            //foreach (var employee in employees)
            //{
            //    Console.WriteLine(employee.Element("Name").Value);
            //}

            foreach (var employee in employees)
            {
                Console.WriteLine("{0} has Employee ID {1}",
                    employee.Element("Name").Value,
                    employee.Element("EmpId").Value);
            }
        }
    }
}
