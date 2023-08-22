using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array
{
    internal class _2nd_smallest
    {    /*Find the 2nd smalleest no :*/
        static void Main(string[] args)
        {
            int[] arr=new int[5];
            for (int i = 0; i < arr.Length; i++) 
            {
                Console.WriteLine( "Enter th no" );
                arr[i]= Convert.ToInt32(Console.ReadLine());
               
            }

            int small = int.MaxValue;
            int small2 = int.MaxValue;
            for (int i = 0; i < arr.Length; i++) 
            {
                if (arr[i]<small)
                {
                    small2 = small;
                    small = arr[i]; 
                }
                if (arr[i] > small && arr[i]<small2) 
                {
                    small2 = arr[i];
                }
            }
            Console.WriteLine($"2nd Smallest NO :{small2}");
            
        }
    }
}
