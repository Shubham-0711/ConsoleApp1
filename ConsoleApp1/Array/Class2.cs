using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array
{

    internal class Class2
    {
        static void Main(string[] args)
        {

            int[] array = new int[5];
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter no :" );
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0;i < array.Length;i++)
            {
                if (array[i]%2==0)
                {
                    Console.WriteLine("even no :" + array[i]);
                    sum = sum + array[i];
                }
                

            }
            Console.WriteLine("Sum of even arr :" + sum );

        }
    }
}
