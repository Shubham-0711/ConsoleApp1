using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StringDemos.ASSI
{
    internal class Reverse_str
    {
        static void Main(string[] args)
        {
            string st = "India is the best";

            char[] c = st.ToCharArray();

            for (int i = c.Length - 2; i >= 0; i--)
            {
                Console.Write(c[i]);
            }
            Console.WriteLine("\n");


            /*string[]st=c.split();*/

            for (int i = 0;i<st.Length;i--)

              {
                Console.Write( "\n"+c[i]);
              }
            Console.WriteLine();

        }
    }
}
