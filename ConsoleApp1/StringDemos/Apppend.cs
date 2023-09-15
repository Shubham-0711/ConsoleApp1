using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.String
{
    public class Apppend
    {
        static void Main(string[] args)
        {
            string str = "Hello to all";
            Console.WriteLine( str );
            Console.WriteLine(str.GetHashCode() );

            str = str + "Good Morning";
            Console.WriteLine( str );
            Console.WriteLine(str.GetHashCode());

            Console.WriteLine("--------String BUilder CLass"  );

            StringBuilder strbuilder= new StringBuilder("Hello to all");
            Console.WriteLine( strbuilder );
            Console.WriteLine(strbuilder.GetHashCode()  );


            strbuilder.Append("GOOD MORNING ");
            Console.WriteLine( strbuilder );

            strbuilder.Remove(4, 5);
            Console.WriteLine(strbuilder);
            Console.WriteLine( strbuilder.GetHashCode() );
        }

    }
}
