﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            //while (i <= 5)
            //{
            //    Console.WriteLine(i);
            //    i++;

            //}
            //Console.ReadKey();

            do
            {
                Console.WriteLine(i);
                i++;

            } while (i < 5);
            Console.ReadKey();
        }
        
    }
}
