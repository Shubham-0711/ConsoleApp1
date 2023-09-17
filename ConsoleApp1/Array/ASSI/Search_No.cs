using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
            bool isfound = false;
            int index=-1;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter NO. :");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ",array));
            Console.WriteLine("Enter Number to search :");
            int m=Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<array.Length;i++)
            {
                if (array[i] == m)
                {
                   isfound = true;
                    index = i;
                }
            }
            if(isfound)
            {
                Console.WriteLine($"{m} found at {index} index");
            }
            else
            {
                Console.WriteLine("not found :");
            }

        }
    }
}
