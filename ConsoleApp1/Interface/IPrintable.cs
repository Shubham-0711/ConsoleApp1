using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;



/*Create an interface with name IPrintable, declare method as Print();
Implement the interface with Employee, Manager, Student class
And display the respective details of that class.*/


namespace ConsoleApp1
{
    internal class Innterface
    {
        static void Main(string[] args)
        {
            Employee1 e= new Employee1();
            e.Print();
            Manager1 m= new Manager1();
            m.Print();
            Student2 s= new Student2();
            s.Print();

        }
    }
    public interface IPrintable
    {
        void Print();
    }
        public class Employee1 : IPrintable
        {
            public void Print()
            {
            Console.WriteLine("hiiiii");
            }
        }
    public class Manager1 : IPrintable
    {
        public void Print()
        {
            Console.WriteLine("it is manger class");
        }
    }
    public class Student2:IPrintable
    {
        public void Print() 
        {
            Console.WriteLine("It is Student class");
        }
    }
}

