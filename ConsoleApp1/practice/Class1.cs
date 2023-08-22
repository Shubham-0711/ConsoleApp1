using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.practice
{
    internal class Class1
    {
        class Employee
        {
            private int id;
            private string name;
            private double basicSalary;
            private double hra,ta,pf;
 

            public Employee(int id, string name, double basicSalary)
            {
                this.id = id;
                this.name = name;
                this.basicSalary = basicSalary;
                this.hra = 0.4 * basicSalary;
                this.ta = 0.2 * basicSalary;
                this.pf = 0.12 * basicSalary;
            }

            public double CalculateSalary()
            {
                return  basicSalary + hra + ta - pf;
            }

            public override string ToString()
            {
                return $"ID: {id} Name: {name} Basic Salary: {basicSalary} HRA: {hra} TA: {ta}" +
                    $" PF: {pf} Gross Salary: {CalculateSalary()}";
            }
        }

        class XYZ
        {
            static void Main(string[] args)
            {

                Employee emp = new Employee(1, "SANKET", 70000);
                Console.WriteLine(emp.ToString());
            }
        }
    }
}
