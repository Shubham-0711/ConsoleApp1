using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace ConsoleApp1.collection
{
    internal class que
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
                
            q.Dequeue();// 10

            Console.WriteLine("1st Element in the Queue "+q.Peek());

            foreach (var item in q)
            {
                Console.WriteLine(item);

            }
        }
    }
}
