using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array
{
    internal class Class1
    {
        public static void Main(string[]args)
        {
            int[] array1 = new int[5];
            int[] array2 = new int[5];
            int[] array3 = new int[5];

            for(int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine("Enter Number");
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0;i < array2.Length; i++)
            {
                if (array1[i] %2== 0)
                {
                    array2[i] = array1[i];
                }
                else
                {
                    array3[i] = array1[i];
                }
            }

            for (int i = 0;i<array2.Length; i++)
            {
                if (array2[i] >0)
                {
                    Console.WriteLine( "Even num." + array2[i] );
                }
            }

            for(int i=0;i<array3.Length; i++)
            {
                if (array3[i] >0)
                {
                    Console.WriteLine("ODD num. " + array3[i] );
                }
            }
        }

    }
}
