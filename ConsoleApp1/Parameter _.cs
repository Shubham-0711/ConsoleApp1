using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Parameter__
    {
        private string Comp_Name, Modle_name;
        private int cost;

        public Parameter__(string comp_Name, string modle_name, int cost)
        {
            Comp_Name = comp_Name;
            Modle_name = modle_name;
            this.cost = cost;

        }

        public void Accept(string modelname, string company = "honda")
        { 
        
        }
    }
}
