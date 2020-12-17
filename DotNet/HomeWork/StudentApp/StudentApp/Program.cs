using StudentApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    class Program
    {
     public static void Main(string[] args)
        {
            Student s = new Student();
            printStudentInfo(s);
           
            Student[] students = new Student[5];
            for(int i = 0; i < students.Length; i++)
            {
                students[i] = new Student();
            }
            students[0].FirstName = "Abhi";
            students[0].LastName = "Darji";
            students[0].IQLevel = IQLevel.AboveAverage;

            students[1].FirstName = "anjali";
            students[1].LastName = "Singh";
            students[0].IQLevel = IQLevel.BelowAverage;

            students[2].FirstName = "Mahi";
            students[2].LastName = "Singh";
            students[0].IQLevel = IQLevel.Average;

            students[3].FirstName = "Parshw";
            students[3].LastName = "Shah";
            students[0].IQLevel = IQLevel.AboveAverage;

            students[4].FirstName = "Rajvi";
            students[4].LastName = "Saha";
            students[0].IQLevel = IQLevel.Average;

            DisplayStudentLongName(students);
            DisplayStudentShortName(students);
        }
        public static void DisplayStudentLongName(Student[] student)
        {
            Console.WriteLine("\nStudents With LongName ");
            for(int i = 0; i < student.Length; i++)
            {
                if(student[i].IsLongName())
                {
                    printStudentInfo(student[i]);
                }
            }
        }

        public static void DisplayStudentShortName(Student[] student)
        {
            Console.WriteLine("\nStudents With Short lName ");
            for (int i = 0; i < student.Length; i++)
            {
                if (!student[i].IsLongName())
                {
                    printStudentInfo(student[i]);
                }
            }
        }

        public static void printStudentInfo(Student s)
        {
            Console.WriteLine("Student FirstName is :" + s.FirstName);
            Console.WriteLine("Student LastName is :" + s.LastName);
            Console.WriteLine("Student's IQLevel  is :" + s.IQLevel);
            Console.WriteLine("\n");
            
        }
    }
}
