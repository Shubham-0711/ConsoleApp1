using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public partial class clac
    {
       public int Add(int a,int b)
        {
            return a + b;

        }
        public int sub (int a,int b) 
        {
            return a - b; 
        }
        public int multi(int a,int b)
        {
            return a * b;
        }
    }
}
