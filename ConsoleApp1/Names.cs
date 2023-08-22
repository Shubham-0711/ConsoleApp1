using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
/*    WAP to accept 5 names using 1D array and display using for loop
*/
    internal class Names
    {
        static void Main(string[] args)
        {
            string[] name = new string[5];
            Console.WriteLine("Enter Name :");

            for (int n = 0; n< name.Length;n++)
            {
                name[n]=Console.ReadLine();
            }

            for (int n = 0; n < name.Length; n++)
            {
                Console.WriteLine(name[n]);
            }
            Console.WriteLine("\n");
        }
    }
}
