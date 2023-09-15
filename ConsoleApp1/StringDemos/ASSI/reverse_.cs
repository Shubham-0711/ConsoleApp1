using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StringDemos.ASSI
{
    internal class reverse_
    {
        static void Main(string[] args)
        {
            string str1 = "Welcom to dp6 dotnet ";
            Console.WriteLine("Original String :"+str1);

           

            for(int i =str1.Length-1;i>=0; i--)
            {
                Console.Write(str1[i])   ;
            }
            
        }

    }
}
