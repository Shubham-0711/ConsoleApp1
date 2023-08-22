using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.practice
{
    internal class REV_PALID
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Enter NO :" );
            int  num =Convert.ToInt32( Console.ReadLine());
            int temp = num;
            int rev = 0;

            while (num > 0) 
            {
                int digit=num % 10;
                rev=rev*10+digit;
                num = num / 10;
            }
            num = temp;
            if (num==rev) 
            {
                Console.WriteLine( "palidrom no :" );
            }
            else
            {
                Console.WriteLine("not palidrom :");
            }
        }
    }
}
