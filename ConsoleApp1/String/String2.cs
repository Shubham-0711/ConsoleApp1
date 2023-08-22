using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.String
{
    public class String2
    {
        static void Main(string[] args)
        {
            string msg = "heloo to all";
            string msg1 = "  Good Morning   ";

            // concat,Trim,TrimStart,TrimEnd,IndexOf,LastIndexOf ,ToUpper , ToLower



            string str =string.Concat(msg.TrimStart()," ", msg1.TrimEnd());
            Console.WriteLine(str);

            Console.WriteLine(msg1.Trim());// remove space 
            Console.WriteLine(str);

            Console.WriteLine(msg1.ToUpper());
            Console.WriteLine(msg.ToLower());
            Console.WriteLine("index =" +msg.IndexOf('o'));
            Console.WriteLine("index =" +msg.LastIndexOf("l"));

            //convert string to array
            string[]strarr=msg.Split(',');
            //convert to char aaray
            char[]ch=msg.ToCharArray();

            string starr2 = new string(ch);
            Console.WriteLine( starr2 );

            foreach(char c in ch )
            {
                Console.WriteLine( c );
            }

            foreach(string s in strarr )
            {
                Console.WriteLine(  s);

            }
            for (int i = 0; i < msg1.Length; i++)
            {
                Console.WriteLine(msg1[i] );

            }








        }
    }
}
