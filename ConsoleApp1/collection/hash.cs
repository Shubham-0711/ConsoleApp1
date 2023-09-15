using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1.collection
{
    internal class hash
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("91", "IND");
            hashtable.Add("93", "Afghanistan");
            hashtable.Add("61", "Australia");

            hashtable.Remove("91");


            foreach(DictionaryEntry item in hashtable)
            {
                Console.WriteLine( $"{item.Key}-->{item.Value }");
            }

            Console.WriteLine("------- SORTED LIST ------");
                
            /*  ---------- SORTED LIST ------*/
            SortedList st=new SortedList();
            st.Add("101", "ADmin");
            st.Add("102","Exam");


            foreach(DictionaryEntry item in st)
            {
                Console.WriteLine( $"{item.Key}--->{item.Value}" );
            }

        }
    }
}
