using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LumenWorks.Framework.IO.Csv;
namespace FileReadWriteApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var csvTable = new DataTable();
            using(var CsvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead(@"E:\demo.csv")),true))
            {
                csvTable.Load(CsvReader);
                for (int i = 0; i < csvTable.Rows.Count; i++)
                {
                    for (int j = 0; j < csvTable.Columns.Count; j++)
                    {
                        string row = csvTable.Rows[i][j].ToString();
                        if(row == "" || row == null)
                        {
                            Console.WriteLine("Unspecified");
                        }
                        else
                        {
                            Console.WriteLine(row);
                        }
                    }
                }
            }
            
            
        }
    }
}
