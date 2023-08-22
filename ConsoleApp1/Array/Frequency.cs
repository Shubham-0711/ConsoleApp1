using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array
{
    /*9.	WAP to count frequency of each element in an array.*/
    internal class Frequency
    {
        static void Main(string[] args)
        {

            int[] Arr = { 2, 4, 5, 2, 4, 3, 2, 2, 2 };

            for (int i = 0; i < Arr.Length; i++)
            {
                int cnt = 1;
                bool isvisited = false;

                for (int k = i - 1; k >= 0; k--)
                {
                    if (Arr[k] == Arr[i])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {
                    for (int j = i + 1; j < Arr.Length; j++)
                    {
                        if (Arr[i] == Arr[j])
                        {
                            cnt++;

                        }
                    }

                    
                        Console.WriteLine(cnt + "  times   " + Arr[i]);
                    
                }
            }
        }


    }
}
