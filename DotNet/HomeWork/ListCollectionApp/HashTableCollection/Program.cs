using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Hashtable g = new Hashtable();
            g.Add(1, "welcome");
            g.Add(2, "to");
            g.Add(3, "tutorials");
            g.Add(4, "of");
            g.Add(5, "C#");

            ICollection key = g.Keys;

            // Print Hash table 
            Console.WriteLine("Hashtable:");
            
            foreach (var val in key)
            {
                Console.WriteLine(val + "-" + g[val]);
            }
            Console.WriteLine();
        }
    }
}
