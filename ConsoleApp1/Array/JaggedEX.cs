using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array
{
    internal class JaggedEX
    {
        static void Main(string[] args)
        {
            int[][] jarr = new int[5][];

            jarr[0] = new int[1];
            jarr[1] = new int[2];
            jarr[2]= new int[3];
            Console.WriteLine("Enter The Value :");


            for (int row = 0;row<jarr.Length;row++)
            {
                for (int col = 0; col < jarr[row].Length;col++)
                {
                    Console.WriteLine(jarr[row][col]+"  ");
                    jarr[row][col] = Convert.ToInt32(jarr[row][col]);
                    
                }
            }
        }
        
            
    }
}
