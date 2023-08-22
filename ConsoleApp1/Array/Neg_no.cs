using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array
{
    internal class Neg_no
/*          WAP to print all negative elements in an array and also count the total number of negative elements in an array.
*/
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[] neg = new int[5];
            for(int i=0;i<neg.Length;i++)
            {
                neg[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i=0;i<neg.Length;i++)
                if (neg[i] < 0) 
            {
                    count++;
                Console.WriteLine(neg[i] );

            }
            Console.WriteLine("Total no = "+count);
        }
    }
}
