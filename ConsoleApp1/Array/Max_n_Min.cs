using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array
{
    internal class Max_n_Min
    {
        public static void Main(string[]args)
        {
            int[]array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine( "Enter Number :" );
                array[i] = Convert.ToInt32( Console.ReadLine());
            }
            int m = array[0];
            for(int i = 1; i < array.Length; i++)
            {
                if (array[i] > m )
                {
                    m = array[i];
                }
            }
            Console.WriteLine("Max No is :" +m);
                
            int n= array[0];
            for (int i = 1;i < array.Length; i++)
            {
                if (array[i]<n)
                {
                    n = array[i];
                }
            }
            Console.WriteLine("Min No is :" +n);
        }
    }
}
