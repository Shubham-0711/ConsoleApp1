using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interface
    /*write code where one child can access 2 interface*/
{
    public  interface INT_2method
    {
        void Method();
    }
    public interface INT_3method 
    {
        void Method();
    }

    public class ParentClass : INT_2method, INT_3method
    {
         void INT_2method.Method()
        {
            Console.WriteLine( "Interface1 for parent class" );
        }
         void INT_3method.Method()
        {
            Console.WriteLine(  "Interface2 for parent class");
        }
    }

    


}
