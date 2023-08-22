using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interface
{
    internal class Program
    {
         public static void Main(string[] args)
          {

            ibook p = new ibook();
            p.accept(1234567891, "Sandesh");
            p.Display();


           INT_2method i1 = new ParentClass();
              i1.Method();
              INT_3method i2= new ParentClass();
              i2.Method();

          }




           
        

    }
}
