using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.practice
{
    internal class sum_Elment
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int sum=0;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine( "Ente elment :" );
               arr [i]=Convert.ToInt32(Console.ReadLine());

            }

            for (int i = 0; i < arr.Length; i++)
            {
                
                    sum = sum +arr[i];
            }

            Console.WriteLine( "sum of elments :" +sum );
        }
    }
}
