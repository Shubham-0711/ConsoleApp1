using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.D_E
{
    public delegate void MyDelegate(); 

    public class Student
    {
          static void Main(string[] args)
            {
                try
                {
                    Student_PNS stud1 = new Student_PNS();
                    

                stud1.Fail += delegate () { Console.WriteLine("You are fail in exam :"); };//anonymous method
                stud1.Pass += delegate () { Console.WriteLine("Your Pass "); };
/*
                    stud1.Fail += new MyDelegate(msg.FailureMessage);
                    stud1.Pass += new MyDelegate(msg.SuccessMessage);*/

                    stud1.AccepPercentage(20);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
           }

    }

    public class Student_PNS
    {
        public event MyDelegate Fail;
        public event MyDelegate Pass;

        public void AccepPercentage(double per)
        {
            if (per <40)
            {
                Fail();
            }
            else
            {
                Pass();
            }
        }
    }

    public class Message
    {
        public void SuccessMessage()
        {
            Console.WriteLine("You pass the Exam");
        }
        public void FailureMessage()
        {
            Console.WriteLine("You are Fail in exam ");
        }
    }
}
