using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array
{

    internal class _1D_Asn
    {
        static void Main(string[] args)
        {
            {
                int[] a = new int[] { 1, 88, 11, 10, 45, 5 }; 
                for (int i = 0; i < a.Length; i++) 
                {
                    for (int j = 0;j<a.Length;j++)
                    {
                        if (a[i] <a[j])
                        {
                            int temp = a[i];
                            a[i] = a[j];
                            a[j] = temp;
                        }
                    }
                }
                Console.WriteLine("ASC Order :");
                foreach (int i in a)
                {
                    
                    Console.WriteLine(i);
                }

                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j < a.Length; j++)
                    {
                        if (a[i] > a[j])
                        {
                            int temp = a[i];
                            a[i] = a[j];
                            a[j] = temp;
                        }
                    }
                }

                Console.WriteLine("DEC Order : ");
                foreach (int i in a)
                {
                    Console.WriteLine(i);
                }
            }
   
        }

    }
}
