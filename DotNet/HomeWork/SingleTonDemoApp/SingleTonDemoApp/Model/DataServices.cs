using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonDemoApp.Model
{
    public class DataServices
    {
        private static DataServices bucket;

        private DataServices()
        {
            Console.WriteLine("Service Created..");
        }
        public static DataServices getInstance()
        {
            if(bucket == null)
            {
                bucket = new DataServices();
            }
            return bucket;
        }
        public void processData()
        {
            Console.WriteLine("Data being Processed " + this.GetHashCode());
        }
    }
}
