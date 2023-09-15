using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.D_E
{
    public delegate string Mydelegate(string s); // always declare in namespace


    internal class Acc_name
    {
        static void Main(string[] args)
        {
            User u = new User();
            Mydelegate md= new Mydelegate(u.Acceptname);
            md+= new Mydelegate(u.NameLower);
            md += new Mydelegate(u.Displayname);

            /*  string result = md.Invoke("shubham");
              Console.WriteLine( result);*/
            Delegate[]list=md.GetInvocationList();

          foreach(Delegate s1 in list)
            {
                Console.WriteLine(s1.Method);
                string result= Convert.ToString(s1.DynamicInvoke("Heloooooo "));
                Console.WriteLine(result);
            }

        }
    }

    public class User
    {
        public string Acceptname(string Name)
        {
            
            return Name.ToUpper();
        }
       public string NameLower(string Name)
        {
            return Name.ToLower();

        }
        public string Displayname(string Name)
        {
            return Name;  
        }
    }

}

