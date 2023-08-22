using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array
{
    internal class _2D_arr_input
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[4, 5];
            for (int row = 0; row < arr.GetLength(0); row++)
            {
               for (int col= 0; col < arr.GetLength(1);col++)
                {
                    arr[row, col] = Convert.ToInt32(Console.ReadLine());
                }


            };

            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    Console.WriteLine($"Index=[{row}],[{col}] = {arr[row, col]}");
                }
                Console.WriteLine( "\n" );
            }
        }
    }
}
