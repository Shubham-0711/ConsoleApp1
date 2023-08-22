using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array
{
    /*7.	WAP to print all unique elements in the array.*/

    internal class Unique
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


                    if (cnt==1)
                    {
                        Console.WriteLine(Arr[i]);
                    }

                }
            }
        }

        
    }
}
