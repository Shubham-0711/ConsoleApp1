using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StringDemos.ASSI
{
    internal class Duplicate
    {
        /*15.	Write a C# program to find the duplicate words and their number of occurrences in a string*/
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string :");
            string st=Convert.ToString(Console.ReadLine());
            string[] str = st.Split();
           


            for (int i = 0; i < str.Length; i++)
            {
                int cnt = 1;
                for (int j = i+1; j < str.Length-1; j++)
                {
                  
                    if (str[i] == str[j])
                    {
                        cnt++;
                        // Console.WriteLine(str[i]);
                        str[j] = " ";

                    }    
                }
                if (str[i] != " ")
                {
                    Console.WriteLine(str[i] + " " + cnt);
                }

            }
           

        }
    }
}
