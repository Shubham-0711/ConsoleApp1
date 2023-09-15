using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StringDemos.ASSI
{
    /*13.	Write a C# program to find total number of alphabets, digits or special character in a string.*/
    internal class find_
    {
        static void Main(string[] args)
        {
            string str = "Shubhamdalvi0611@gmail.com";
            Console.WriteLine(str);
            int cnt1 = 0;
            int cnt2 = 0;
            int cnt3 = 0;

            char[]ch=str.ToCharArray();

            for (int i = 0; i < ch.Length; i++)
            {
                if ((ch[i] >= 'a' && ch[i] <= 'z') || (ch[i] >= 'A' && ch[i] <= 'Z'))
                {
                    cnt1++;
                }
                else if ((ch[i] >= '0' && ch[i] <= '9'))
                {
                    cnt2++;

                }
                else 
                {
                    cnt3++;
                }
            }
            Console.WriteLine("Total Number of Alphabates : "+cnt1);
            Console.WriteLine("Total Number of Digit : " + cnt2);
            Console.WriteLine("Total number of symbol : "+cnt3);

        }

    }
}
