using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UppercaseLowercaaseLengthApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string Message = "i am learning c#";
            string message = "I AM LEARNING C IN SWABHAV";
            int a = 10;
            Uppercase(Message);
            LowerCase(message);
            Length(message);
        }
        public static void Uppercase(string Message)
        {
            Console.WriteLine("String in Uppercase is : " + Message.ToUpper());
        }
        public static void LowerCase(string message)
        {
            Console.WriteLine("String in Uppercase is : " + message.ToLower());
        }
        public static void Length(string message)
        {
            Console.WriteLine("String Length is : " + message.Length);
            Console.WriteLine(message.GetHashCode());
        }
    }
} 
