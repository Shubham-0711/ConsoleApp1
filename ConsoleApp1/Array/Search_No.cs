using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array
{
    internal class Search_No
    {
        static void Main(string[] args)
        {
            int[] array=new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter NO. :");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter Number to search :");
            int m=Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<=array.Length;i++)
            {
                if (array[i] == m)
                {
                    Console.WriteLine( $"{m} found at {i} index" );
                }
            }
        }
    }
}
