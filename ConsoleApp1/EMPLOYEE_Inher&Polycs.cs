/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    *//*From the existing Employee class create new child class called SalesEmployee

& implement the inheritance(bonus+comm) & polymorphism(method overriding)
*//*
    public class EMPLOYEE_Inher_Polycs
    {
        protected int id;
        protected string name;
        protected double salary, hra, da, ta, PF, gross;
        private static int count;
        //constructor 
        public EMPLOYEE_Inher_Polycs() //parameter less constructor

        //assign default value
        {

            id = 0;
            name = "";
            salary = 0.0;
        }

        public EMPLOYEE_Inher_Polycs(string name, double salary)//parametric constructor
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

        public virtual void CalculateSalary()
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

    public class Mang : EMPLOYEE_Inher_Polycs
    {
        private double Fooodallownce;
        public Mang(double Fooodallownce, string name, double salary) : base(name, salary)
        {
            this.Foooda_llownce = Fooodallownce;

        }

        public override void Calculate_Salary()
        {
            hra = salary * 0.40;
            da = salary * 0.20;
            ta = salary * 0.10;
            PF = salary * 0.12;
            gross = (salary + hra + da + ta+Fooodallownce) - PF;
        }

        public override string Print_sal()
        {
            return $"Manager's Gross Salary :{gross} ";
        }

       *//* public class Sales_emp:EMPLOYEE_Inher_Polycs
        {
            private double bonus;
            private double comm;
        }

        public Sales_emp(double bonus,double comm,string name, double salary) : base(name, salary)
        {
            this.bonus=bonus;
            this.comm = comm;

        }
        public

        public override void CalculateSalary()
        {
            hra = salary * 0.40;
            da = salary * 0.20;
            ta = salary * 0.10;
            PF = salary * 0.12;
            gross = (salary + hra + da + ta+bonus+comm) - PF;
*//*
        }
    }
}
*/