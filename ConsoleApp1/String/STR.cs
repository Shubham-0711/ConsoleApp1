using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.String
{
    public class STR
    {
        static void Main(string[] args)
        {
            string msg = "hello";
            string msg1 = "good morning";
            Console.WriteLine(msg.GetHashCode()); //returns the address location of variable


            msg = msg + "   HIII";
            Console.WriteLine(msg);
            Console.WriteLine(msg.GetHashCode());

        }
    }
}
