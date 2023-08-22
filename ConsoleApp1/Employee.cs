using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee
    {

        protected int id;
        protected string name;
        protected double salary, hra, da, ta, PF, gross;
        private static int count;
        //constructor 
        public Employee() //parameter less constructor

        //assign default value
        {

            id = 0;
            name = "";
            salary = 0.0;
        }

        public Employee(string name, double salary)//parametric constructor
        {
            count++;
            this.id = count;
            this.name = name;
            this.salary = salary;
        }

        public static int GetEmpCount()
        {
            return count;
        }

        public virtual void  CalculateSalary()
        {
            hra = salary * 0.40;
            da = salary * 0.20;
            ta = salary * 0.10;
            PF = salary * 0.12;
            gross = (salary + hra + da + ta) - PF;

        }
        public virtual string Print()
        {
            return $"Emp id={id}, name={name}, Basic  salary={salary},Gross={gross}";
        }
    }

   public class Manager :Employee
    {
        private double Fooodallownce;
            public Manager(double Fooodallownce,string name,double salary ):base(name,salary) 
        {
            this.Fooodallownce = Fooodallownce;

        }

        public override void CalculateSalary()
        {
            hra = salary * 0.40;
            da = salary * 0.20;
            ta = salary * 0.10;
            PF = salary * 0.12;
            gross = (salary + hra + da + ta) - PF;
        }

        public override string Print()
        {
            return $"Manager's Gross Salary :{gross} ";
        }

        public class Sales:Employee
        {
            private double bounus,comm;
            public Sales(double bounus, double comm, string name, double salary) : base(name, salary) 
            {
                this.bounus = bounus;
                this.comm = comm;
            }
            public override void CalculateSalary()
            {
                hra = salary * 0.40;
                da = salary * 0.20;
                ta = salary * 0.10;
                PF = salary * 0.12;
                gross = (salary + hra + da + ta+bounus+comm) - PF;
            }
            public override string Print()
            {
                return $"Manager's Gross Salary :{gross} ";
            }
        }
    }

}

