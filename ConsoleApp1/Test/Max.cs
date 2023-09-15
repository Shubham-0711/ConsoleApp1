using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Test
{
    //find the Max number from array 
    internal class Max
    {
        static void Main(string[] args)
        {
            
            int[] arr = new int[5];
            int m = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter Element  :");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

           
            for(int i = 1; i < arr.Length; i++)
            {
                if (arr[i]>m)
                {
                    m = arr[i];

                }
            }
            Console.WriteLine("Max no in array is : "+m);

        }
    }
}
