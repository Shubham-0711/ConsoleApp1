using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array
{
    internal class Rainfall

    {
        static void Main(string[] args)
        {
            int[] rainfall = new int[7];
            for (int i = 0; i <rainfall.Length; i++)
            {
                Console.WriteLine( "Enter  value" );
                rainfall[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("print all the value");

            for (int i = 0; i < rainfall.Length; i++)
            {
                Console.WriteLine($"Rainfall[{i}]={rainfall[i]}");
            }
        }
    }
}
