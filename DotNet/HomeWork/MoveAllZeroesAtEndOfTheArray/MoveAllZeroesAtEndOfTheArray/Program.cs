using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveAllZeroesAtEndOfTheArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1,2,0,3,4,0,5,6,0,7};
            int n = arr.Length / arr[0];
            pushZeroToEnd(arr,n);
            Console.WriteLine("Array after pushing all Zeros to end of array : \n");
            for(int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        //Push all Zeros at the end
        public static void pushZeroToEnd(int[] array,int n)
        {
            int count = 0;

            for(int i=0; i < n; i++)
            {
                if(array[i] != 0)
                {
                    array[count++] = array[i];
                }
            }
            while(count < n)
            {
                array[count++] = 0;
            }
        }
    }
}
