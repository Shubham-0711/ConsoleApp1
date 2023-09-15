using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1.Array
{
    /*WAC to display alternate element from the array*/
    internal class alternate
    {
        static void Main(string[] args)
        {
            int num;
            int[] array = new int[5];
            

            for (int i = 0;i<array.Length; i++)
            {
                Console.WriteLine( "Enter NO :" );
                array[i]=Convert.ToInt32( Console.ReadLine() );
            }

            for (int i = 2;i<array.Length; i++)
            {
                if(array[i]>0 )
                {
                    num  = array[i];
                    
                }
             }

            Console.WriteLine("Alternate no :" + array);

        }
    }
}
