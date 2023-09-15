using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array.ASSI
{
    internal class PRINT_zero
    {
        static void Main(string[] args)
        {
            int[]arr=new int[5];
            
            for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine(  "Enter Elements :");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i=0 ; i<arr.Length ; i++)
            {
                if (arr[i]%5 == 0)
                {
                    arr[i] = 0;
                }
                Console.WriteLine(arr[i]);
            }
        }
    }
}
