using ConsoleApp1.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.Inheritance_Person.Person;
using static ConsoleApp1.Manager;
//FCL
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* //for date
             //create object of class
             Date dateObj1 = new Date();

             //call method 
             dateObj1.AcceptDate(4, "Aug", 2023);//Method call

             string res = dateObj1.PrintDate();
             Console.WriteLine(res);*/


            //for Student 
            /*Student student1 = new Student();
            student1.AcceptStudent(1,100,100,100,"shubh","BCA");
            student1.PrintStudent();

            student1.Percentage();
            
            string re = student1.PrintStudent();
            Console.WriteLine(re);
            student1.Grade();
*/
            //for Employee
            /*
                        Employee emp = new Employee();
                        emp.Accept("Shubham", "IT", 100000);
                        emp.calculate();

                        string EM = emp.PrintEmployee();
                        Console.WriteLine(EM);
            */

            //parameter less constructor get callled

            /* Employee employee = new Employee(); //Employee call to constructor

             Employee employee2 = new Employee( "Shubham", 23000);
             Employee employee3 = new Employee( "Sager", 20000);   //employee2&3 call parametric constructor.

             employee2.CalculateSalary();
             employee3.CalculateSalary();
             Console.WriteLine(employee2.Print());
             Console.WriteLine(employee3.Print());

             Console.WriteLine("totatl no emp "+Employee.GetEmpCount());
 */


            /*
                        {
                            Console.WriteLine("Enter the default balance");
                            double bal = Convert.ToDouble(Console.ReadLine());
                            BANK b1 = new BANK(10011, "Rohan", bal);
                            Console.WriteLine(b1.Print());
                            b1.Credit(2300.50);
                            Console.WriteLine(b1.Print());

                            string msg = b1.Debit(17301);
                            Console.WriteLine(msg);
                            Console.WriteLine(b1.Print());
                        }*/



            /*
                        //property initializer syntax
                        Student1 stud1 = new Student1();
                        stud1.RollNo = 1; //it calls th eset accesor
                        stud1.Name = "shubh";
                        stud1.Percentage = 70.25;

                        //it calls the get accesor 
                        Console.WriteLine($"{stud1.RollNo }{stud1.Name }{stud1.Percentage }");
                        Console.WriteLine(stud1.ToString());

                        //object initializer syntax
                        Student1 stud2 = new Student1(){RollNo=2  ,Name="sham"  ,Percentage=80.02};
                        Console.WriteLine($"{stud2.RollNo }{stud2.Name }{stud2.Percentage }");



                        Product prd = new Product();
                        prd.Code=1;
                        prd.Name = "prd1";
                        prd.Price = 100;

                        Console.WriteLine($"{prd.Code}{prd.Name}{prd.Price}");
                        Console.WriteLine(prd.ToString());

                        Product prd2 = new Product() { Code=2  ,Name="ram",Price=150};
                        Console.WriteLine();
            */

            /* Movie m1=new Movie(1,"xyz",100,10);
            m1.DisplayMovie();

             m1.FindAvailableTickets();
             m1.Details();

 */
            /*

                        M_overloading m_O = new M_overloading();
                        Console.WriteLine(C.Addition(10+20));
                        Console.WriteLine(C.Addition(10+20+30) );*/


            /* Parameter__ p1=new Parameter__("honda","city",10000);
             p1.Accept("xyz");
             p1.Accept("abc", "honda");

             Parameter__ p2 = new Parameter__("honda","wns",1100000);*/


            //   -------------------------------------------------------------------//

            /*
            Patient p1 = new Patient("A+", "Sahil", "PIMPRI", 1213313);
            Console.WriteLine(p1.PrintInfo()); */




            /*

             Rectangle t1 = new Rectangle(10,30);
             t1.Area();
             Console.WriteLine(t1.Display());
             Console.WriteLine(t1.Print()  );
 */

            // Interface

            /* User s1 = new User();
             Console.WriteLine(s1.Print());*/

            /*
                        ICustomer c1 = new Transaction();
                        Console.WriteLine(c1.Display());

                        IOrders o1 = new Transaction();
                        Console.WriteLine(o1.Display());*/



            /*calc e1=new calc();
            Console.WriteLine(e1.Sqr(2));*/
            
            /*
            Empl e = new Empl();//ovr
            e.Show(1, "Shubham");
*/
           /* //base 
            Manager m1 = new Manager(200, "XYZ", 200000);
            m1.CalculateSalary();
            Console.WriteLine(m1.Print());

            Employee e1 = new Sales(200, 200, "xyz", 250000);
            e1.CalculateSalary();
            Console.WriteLine(e1.Print());*/


            c1 ch = new c1(01,1,"shubh");
            Console.WriteLine(ch.Display());





        }
    }
}
