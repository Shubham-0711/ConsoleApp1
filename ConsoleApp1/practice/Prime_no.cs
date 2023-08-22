using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.practice
{
    internal class Prime_no
    {
        static void Main(string[] args)
        {
            for (int i = 11; i<= 21; i++)
            {
                bool isPrime=true;
              for(int j = 2; j<i; j++) 
                {
                    if(i%j==0) 
                    {
                        isPrime = false;
                        break;
                    }
                }
              if(isPrime==true)
                {
                    Console.WriteLine( i );

                }

            }
        }
    }
}
