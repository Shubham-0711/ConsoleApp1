using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.practice
{
    internal class MAX_ch
    {
        static void Main(string[] args)
        {
            char[] c = new char[5];
            char MAX =c[0] ;

            for(int i=0; i<c.Length; i++)
            {
                Console.WriteLine( "Enter Charters :" );
                c[i] = Convert.ToChar(Console.ReadLine());
            }
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] > MAX)
                {
                    MAX = c[i];
                }
            }
            Console.WriteLine(MAX);

        }
    }
}
