using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;using System.Text;
using System.Threading.Tasks;

namespace LinqToFileSystem
{
    class Program
    {
       static DirectoryInfo filedir = new DirectoryInfo(@"C:\Windows\System32");

        static IEnumerable<System.IO.FileInfo> fileList = filedir.GetFiles("*.*", System.IO.SearchOption.TopDirectoryOnly);

        static IEnumerable<System.IO.DirectoryInfo> folderList = filedir.GetDirectories("*.*", System.IO.SearchOption.TopDirectoryOnly);
        static void Main(string[] args)
        {
            //Case1();
            //Case2();
            //Case3();
            Case4();
            //var files = from file in filedir.GetFiles()

            //            select new { FileName = file.Name, FileSize = (file.Length / 1024) + " KB" };

            //Console.WriteLine("FileName" + "\t\t\t\t | " + "FileSize");

            //Console.WriteLine("--------------------------");

            //foreach (var item in files)

            //{

            //    Console.WriteLine(item.FileName + "\t\t\t\t | " + item.FileSize);

            //}

            //Console.ReadLine();
        }

        public static void Case1()
        {
            var file = fileList.OrderBy(x => x.Length).Take(3);

            foreach(var i in file)
            {
                Console.WriteLine(i.Name + "\t" + i.Length);
            }
        }

        public static void Case2()
        {
            var file = fileList.OrderByDescending(x => x.Length).Take(3);

            foreach (var i in file)
            {
                Console.WriteLine(i.Name + "\t" + i.Length);
            }
        }

        public static void Case3()
        {
            var file = filedir.GetFiles();

            foreach (var i in file)
            {
                Console.WriteLine("Directory Name : " + i.DirectoryName);
                Console.WriteLine("\nFile Name : " + i.Name);
                Console.WriteLine("\nFile Size : " + i.Length);
                Console.WriteLine("\nCreated Date : " + i.CreationTime);
            }
        }

        public static void Case4()
        {
            var folder = filedir.GetDirectories().OrderBy(x => x.Name);

            foreach (var i in folder)
            {
                Console.WriteLine(i);
            }
        }
    }
}
