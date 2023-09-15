using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StringDemos.ASSI
/*8.	Write a C# program to toggle case of each character of a string.*/
{
    internal class Tog_ch
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter String : ");
            string str = Convert.ToString(Console.ReadLine());
            char[]c=str.ToCharArray();

            for (int i = 0; i < str.Length; i++)
            {
                if (c[i] >= 'A' && c[i]<='Z')
                {
                    c[i] = (char)(c[i] + 32);
                    Console.WriteLine(c[i]);

                }
                else if (c[i]>='a' && c[i]<='z')
                {
                    c[i] = (char)(c[i] - 32);
                    Console.WriteLine(c[i]);

                }
                
            }
            



        }
        
        
    }
}
