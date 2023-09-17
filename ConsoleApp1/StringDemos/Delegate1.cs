using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.StringDemos.User;

namespace ConsoleApp1.StringDemos
{     /*Create a class User, create a method with name AccpetName(string name), convert the name in
     * upper case & return.
   \   Create the delegate to hold AcceptName method reference & invoke using delegate*/
        internal class Delegates1
        {
            static void Main(string[] args)
            {
                User u = new User();
                Mydelegate md = new Mydelegate(u.AcceptName);

                string result = md.Invoke("Hello");
                Console.WriteLine(result);
            }
        }

        public class User
        {
            public delegate string Mydelegate(string s);
            public string AcceptName(string name)
            {
                return name.ToUpper();

            }
        }

    
}
