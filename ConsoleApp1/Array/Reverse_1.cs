using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array
{
    /*  12.WAP to reverse the array itself, don’t print array in reverse – 
     *  I want current array reverse.Means e.g.arr[] = [3, 90, 45, 29, 37, 78]
     *  so your same array must be [78, 37, 29, 45, 90, 3] without using temporary array.
    */
    public class Reverse_1
    {
        static void Main()
        {
            int[] arr = { 3, 90, 45, 29, 37, 78 };

            Console.WriteLine("Original Array:");
            PrintArray(arr);

            ReverseArray(arr);

            Console.WriteLine("\nReversed Array:");
            PrintArray(arr);
        }
        static void ReverseArray(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start < end)
            {
                // Swap the elements at start and end indices
                arr[start] = arr[end];
                arr[end] = arr[start];
                arr[start] = arr[end];

                // Move the indices towards the center
                start++;
                end--;
            }
        }

        static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

    }
}

