using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.String
{
    internal class Employee
    {

        int id;
        string name;
        int salary;

        public Employee(int id, string name, int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public override string ToString()
        {
            return id + " " + name + " " + salary;
        }

        static void Main(string[] args)
        {
            Employee[] EMP = new Employee[3];
            for (int i = 0; i < EMP.Length; i++)

            {

                Console.WriteLine("Enter ID :");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Name :");
                string name = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Enter Salary :");
                int salary = Convert.ToInt32(Console.ReadLine());

                EMP[i] = new Employee(id, name, salary);
            }

            /* EMP[0] = new Employee(101, "Shubham", 71000);
             EMP[1] = new Employee(102, "Nikhil", 72000);
             EMP[2] = new Employee(103, "Gauri", 81000);*/

            /*   foreach (Employee E in EMP)
               {
                   Console.WriteLine( E);

               }*/
            /*for (int i = 0; i < EMP.Length; i++)
            {
                Console.WriteLine(EMP[i]);
            }*/
            for (int i = 0; i < EMP.Length; i++)
            {
                if (EMP[i].salary > 20000)
                {
                    Console.WriteLine(EMP[i]);
                }
            }

            }
        }
    }


