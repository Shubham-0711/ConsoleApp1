using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StringDemos
{
    internal class practice
    {
        static void Main(string[] args)
        {

            string str1 = "Shubham";
            string str2 = "Dalvi";

            string str3 = " ";
            Console.WriteLine(str1);

            Console.WriteLine(str1.GetHashCode()); // hashcode shows memory location
            {

                //for addition of strings
                str1 = str1 + "hiii";
                str3 = str1 + str2;

             }
            Console.WriteLine(str3);
            Console.WriteLine(str1);

           /* string st = "hiiii to all";
            string st = "Hiii To ALll";


            string st = string.Concat(st, " ", st.);
*/



        }

    }

}
