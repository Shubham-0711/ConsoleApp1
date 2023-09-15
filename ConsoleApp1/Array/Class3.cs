using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];

            for (int i = 0;i<array.Length;i++)
            {
                Console.WriteLine( "Enter No :" );
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i<array.Length;i++)
            {
                if (i%2!=0)
                {
                    Console.WriteLine("odd No :" +array[i]);

                }
            }
        }
       
    }
}
