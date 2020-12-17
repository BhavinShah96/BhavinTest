using PersonTestApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonTestApp
{
    class Program
    {
        public static double Bmi;
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "Bhavin";
            p.Age = 24;
            p.Gender = "Male";
            p.Weight = 70;
            p.Height = 5.5;

            PrintPersonInfo(p);
            CalculateBmiIndex(p);
        }
        public static void CalculateBmiIndex(Person p)
        {
             Bmi = (p.Weight / (p.Height * p.Height));
            Console.WriteLine("BMI index Calculation is : " + Bmi);
        }
        public static string WeightStatus()
        {
            if (Bmi < 18.5)
                return "Under Weight";
            else if (Bmi > 18.25 && Bmi < 29.5)
                return "Normal Weight";
            else
                return "Over Weight";
        }
        public static void PrintPersonInfo(Person p)
        {
            Console.WriteLine("Person Name is :" + p.Name);
            Console.WriteLine("Person Height is :" + p.Height);
            Console.WriteLine("Person Weight Befor Eating : " + p.Weight);
            Console.WriteLine("person Weight After Eating : " + p.IsEating());
            Console.WriteLine("person Weight After Diating : " + p.IsDiating());
            Console.WriteLine(" Weight Status is :" + WeightStatus()); ;
        }
    }
}
