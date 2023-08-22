using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    abstract public class Shape
    {


        public abstract string Draw(string name);
        public abstract void Area();
        public string Display()
        {
            return "this is Rectangle Class";
        }
    }
    public class Rectangle : Shape
    {
        private double area;
        private int l;
        private int b;

        public Rectangle(int l, int b)
        {
            this.l = l;
            this.b = b;
        }

        public override void Area()
        {
            area = l * b;
        }
        public override string Draw(string name)
        {
            return name;
        }
        public string Print()
        {
            return $"area of circle is {area}";

        }
    }
}
