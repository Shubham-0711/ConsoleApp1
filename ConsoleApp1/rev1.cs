using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
        public abstract class person
    {
        int id;
        string name;
        public abstract void Show(int id, string name);
    }
    public class Empl: person
    {
        public override void Show(int id, string name)
        {
            Console.WriteLine($"ID: {id}, Name: {name}");
        }
    }

}
                                              