using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1.collection
{
    internal class St
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push(10);
            st.Push(20);
            st.Push(30);    


            st.Pop();//remove the top element

            Console.WriteLine( "Top element "+st.Peek() );

            foreach( var item in st )
            {
                Console.WriteLine(item);

            }

        }
    }
}
