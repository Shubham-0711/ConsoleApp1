using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Reverse_no
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number :");
            int num=Convert.ToInt32(Console.ReadLine());
            int rev = 0;


            while(num > 0)
            {
                int digit = num % 10;
                rev = rev * 10 + digit;
                num = num / 10;

            }
            Console.WriteLine("Reverse no is :" + rev);
        }
    }
}
