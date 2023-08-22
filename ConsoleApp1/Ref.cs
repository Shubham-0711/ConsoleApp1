using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

   
    public class Ref
    {
        static void Swap( int a,  int b)
        { 
           int temp;
           temp=a;
           a=b;
           b=temp;
        }
        static void Main(string[] args)
        {
            int a = 100, b = 10;
            Swap( a, b);
            Console.WriteLine($"a={a},b={b}");
        }
    }
}
