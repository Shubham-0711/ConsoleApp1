using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array
{
    internal class Even_no
    {
        static void Main(string[] args)
        {
            int[]number =new int[10];
            for(int i=0;i<number.Length;i++)
            {
                
                number[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i=0;i<number.Length;i++)
            if (number[i] % 2 == 0)
            {
                Console.WriteLine($"Even no is ={number[i]}");
            }

        }
    }
}
