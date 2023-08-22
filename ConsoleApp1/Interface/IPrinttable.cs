using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interface
{
    public interface IPrinttable
    {
        string Print();
    }
    public class User : IPrinttable
    {
        public string Print()
        {
            return "User Details";
        }
    }
}
