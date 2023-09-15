using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Test
{
    internal class rev_string
    {
        static void Main(string[] args)
        {
            string s = "mahbhuhs";
            string s1 = "";
            string rev = "";

            char[]chars = s.ToCharArray();
            for (int i = chars.Length-1;i>=0; i--)
            {
                rev = rev + chars[i];

            }
            s1=s1+rev;
            Console.WriteLine(s1);
        }
    }
}
