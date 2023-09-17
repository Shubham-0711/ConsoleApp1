using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StringDemos.ASSI
{
    internal class LongestWord
    {
        static void Main(string[] args)
        {
            string str = "longest small";
            Console.WriteLine(str);

            string[] str1 = str.Split(' ');
            string str2 = " ";
            int max = 0;

            for (int i = 0; i < str1.Length; i++)
            {
                int a = str1[i].Length;
                if (a > max)
                {
                    max = a;
                    str2 = str1[i];
                }
            }
            Console.WriteLine(str2);
        }


    }
}
