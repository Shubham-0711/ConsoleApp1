using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StringDemos.ASSI
{
    /*10.	Write a C# program to find reverse of a string*/
    internal class rev_str
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String :");
            string str =Convert.ToString(Console.ReadLine());

            for (int i =str.Length-1; i>=0; i--) 
            {
                Console.WriteLine(str[i]);
            }
        }

    }
}
