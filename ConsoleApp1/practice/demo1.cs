using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.practice
{
    internal class demo1
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i < 20; i++) 
                if (i %2!= 0)
            {
                    sum = sum + 1;
                    
                }
            Console.WriteLine(sum);
        }

    }
}
