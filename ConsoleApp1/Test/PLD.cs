using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Test
{
    internal class PLD
    {
        static void Main(string[] args)
        {
            Console.WriteLine(  "Enter no :");
            int num=Convert.ToInt32( Console.ReadLine() );
            int temp = num;
            int rev = 0;

            while( num > 0 ) 
            {
                int digit =num % 10;
                rev = rev * 10 + digit;
                num=num / 10;
            
            }
            num = temp;
            if( num ==rev ) 
            {
                Console.WriteLine(" no is palidrome");
            }
            else 
            {
                Console.WriteLine("not palidrome ");

            }
        }
    }
}
