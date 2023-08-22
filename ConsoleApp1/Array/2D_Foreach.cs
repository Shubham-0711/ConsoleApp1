using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1.Array
{
    internal class _2D_Foreach
    {
        static void Main(string[] args)
        {
            int[,] num = new int[3, 4]
        {
          {10,20,30,40 },
          {60,70,80,90},
          { 110,120,130,140}
        };

            foreach (int s in num)
            {
                Console.WriteLine(s);

            }
        }

        


    }
}
