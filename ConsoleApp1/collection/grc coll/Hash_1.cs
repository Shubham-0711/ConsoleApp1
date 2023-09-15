using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.collection.grc_coll
{
    internal class Hash_1
    {
        static void Main(string[] args)
        {

            HashSet<string> list1 = new HashSet<string>();

            list1.Add("pune");
            list1.Add("mumbai");
            list1.Add("nagpur");
            list1.Add("banglore");


            HashSet<string>list2 = new HashSet<string>();

            list2.Add("pune");
            list2.Add("nashik");
            list2.Add("solapur");
            list2.Add("nager");


          /*  list1.Remove("nashik");
            //list1.Clear();
            foreach (string item in list1)
            {
                Console.WriteLine( item );
            }*/


            list1.Union(list2);
            //combine the result and dislay unique elemsts
            //list1.IntersectWith(list2);
            //1st list matched with 2nd and only ,atched elements display
//list1.ExceptWith(list2);
            //compare 1st list with 2nd and only unique elements from list1 get accept


            foreach (string item in list1)
            { 
                Console.WriteLine( item ); 
            }

        }
    }
}
