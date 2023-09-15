using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StringDemos.ASSI
{
   /*Write a C# program to count total number of vowels and consonants in a string.*/

    internal class cnt_v
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Enter String :" );
            string str=Convert.ToString( Console.ReadLine() );
            char[] c = str.ToCharArray();
            int cnt1 = 0; int cnt2 = 0;


            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == 'a' || c[i] == 'e' || c[i] == 'o' || c[i] == 'u' || c[i] == 'A' || c[i] == 'E' || c[i] == 'O' || c[i] == 'U')
                {
                    cnt1++;
                }

                else if (c[i]!=' ')
                {
                    cnt2++;
                }
            }
            Console.WriteLine("Vowels count : "+cnt1);
            Console.WriteLine("Constants : "+cnt2  );

        }
    }
}
