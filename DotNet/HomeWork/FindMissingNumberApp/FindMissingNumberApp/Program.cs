using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMissingNumberApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1,2,3,5,6,7};
            int[] arr1 = { 1, 2, 3, 5, 6, 7 };

            missingNo(arr);
            reverseArray(arr);

            Console.WriteLine("After Removing Duplicate Values from array");
            removeDuplicateFormArray(arr);
            frequentNumber(arr);
            arrayEquality(arr, arr1);

        }
        // Missing No Logic
        public static void missingNo(int[] a)
        {
            int TotalSum = (a.Length + 1) * (a.Length + 2) / 2;

            foreach (int item in a)
            {
                TotalSum = TotalSum - item;
            }
            int missingNo = TotalSum;
            Console.WriteLine("Missing No is :" + missingNo);
        }

        // Reverse Array Logic
        public static void reverseArray(int[] arr)
        {
            Console.WriteLine("Reverse Array is");
            for (int i = arr.Length - 1; i >= 0; i--)
            {

                Console.WriteLine(arr[i]);
            }
        }
        // Remove Duplicate Array Logic
        public static void removeDuplicateFormArray(int[] a)
        {
            int y = 0;
            int arrSize = a.Length;
            for (int i = 0; i < arrSize; i++)
            {
                if (a[i] != a[y])
                {
                    y++;
                    a[y] = a[i];
                }
            }
            arrSize = y + 1;
            for (int i = 0; i < arrSize; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        // Frequent No Logic
        public static void frequentNumber(int[] a)
        {
            int count = 1, tempCount;
            int frequentNo = a[0];
            int tempNo = 0;
            for(int i = 0; i < a.Length - 1;i++)
            {
                tempNo = a[i];
                tempCount = 0;
                for(int j = 0; j < a.Length;j++)
                {
                    if(tempNo == a[j])
                    {
                        tempCount++;
                    }
                }
                if(tempCount > count)
                {
                    frequentNo = tempNo;
                    count = tempCount;
                }
            }
            Console.WriteLine("The Most Frequent No in this array is {0} has been repeates {1} times " ,frequentNo,count);
        }

        // Array Equality logic
        public static void arrayEquality(int[] a,int[] b)
        {
            bool isArrayEqual = true;
            if(a.Length == b.Length)
            {
                for(int i = 0; i < b.Length; i++)
                {
                    if(b[i] != a[i])
                    {
                        isArrayEqual = false;
                    }
                }
            }else
            {
                isArrayEqual = false;
            }
            if (isArrayEqual)
            {
                Console.WriteLine("Both Arrays are Equal");
            }
            else {
                Console.WriteLine("Arrays are not Equal");
            }
        }
    }
}
