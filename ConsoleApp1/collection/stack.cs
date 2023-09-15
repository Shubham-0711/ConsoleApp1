using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1.collection
{
    internal class stack
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            stack.Pop();// remove the top element
            Console.WriteLine(""  );
            Console.WriteLine("Top Element  :"+stack.Peek());

            foreach (var item in stack)
            {
                Console.WriteLine(item);

            }
        }
    }
}
