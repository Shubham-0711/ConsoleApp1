using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.Array
/*
  Write two methods that return the average of an array with following headers.
                                                i.  public static int average(int[] array)
                                               ii.  public static double average(double[] array).
                                              iii.Write main and invoke the 2 methods.*/
{
    public class Avg
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[5];
            Console.WriteLine(average(array1));
            int[] array2 = new int[3];
            Console.WriteLine(average(array2));

        }
        public static int average(int[] array)
        {
            int cnt = 0;
            int sum = 0;
            int avg;

            for (int i = 0; i < array.Length-1; i++)
            {
                Console.WriteLine( "Entr num :" );
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
                cnt++;
            }

            Console.WriteLine("sum is "+sum);
            avg = sum / cnt;
            Console.WriteLine("Avg is" + avg);
            return avg;
        }
        public static double average(double[] array)
        {
            int cnt = 0;
            double avg, sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter NUM :");
                array[i] =Convert.ToDouble(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                sum = (double)sum + array[i];
                cnt++;
            }

            avg = (double)sum / cnt;
            return avg;
        }
    }
}