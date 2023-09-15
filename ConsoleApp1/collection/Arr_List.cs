using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.collection
{
    public class Arr_List
    {
        static void Main(string[] args)
        {
          /*  int[] arr = new int[] { 60, 40, 50, 80 };*/
            ArrayList list = new ArrayList(); 
            list.Add(11);
            list.Add(12);
            list.Add(13);
/*
            list.Insert(1,12);
            list.AddRange(arr);
            *//*list.Remove(1.5);*//*

           list.Sort();
            list.Reverse();
            Console.WriteLine("count (total elements)"+list.Count);
            Console.WriteLine("Capicity "+list.Capacity  );*/

            foreach (var item in list) ;
            {
                Console.WriteLine(list);
            }

        }
    }
}
