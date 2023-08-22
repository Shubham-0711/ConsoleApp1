using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student1
    {
        private int rollno;
        private string name;
        private double percentage;


        //syntax of property--RollNo is a property name
        public int RollNo
        {
            set { rollno = value; }//value is a built in keyword--assign the value
            get { return rollno; }
        }
        public string Name
        {
            get { return name; } 
            set { name = value; }
        }
        public double Percentage
        {
            get { return percentage; }
            set { percentage = value; }
        }
        public string Print ()
        {
            return $"Student{ rollno},{ name},{ percentage}";
        }
    }
}
