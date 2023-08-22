using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class M_overloading
    {
        public int Addition(int a,int b)
        {
            return a + b;

        }
        public int Addition2(int a,int b ,int c)
        { 
            return a + b+ c; 
        }   
        public double Addition3(int a, double b)
        {
            return a + b;
            
        }
        public double Addition4( double a ,double b)
        {
            return a + b;
        }
    }
}

