using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Inheritance_Person
    {
        public class Person
        {

            protected string Name;
            protected string Add;
            protected int AdhaarNo;

            public Person(string Name, string Add, int AddharNo)
            {
                this.Name = Name;
                this.Add = Add;
                this.AdhaarNo = AdhaarNo;
            }

            public virtual string PrintInfo()
            {
                return $"{Name}{Add}{AdhaarNo}";

            }
            public class Patient : Person
            {
                private string BG;

                public Patient(string BG, string Name, string Add, int AdhaarNo) : base(Name, Add, AdhaarNo)

                {
                    this.BG = BG;
                }
                public override string PrintInfo()
                {
                    return $"{BG},{Name},{Add},{AdhaarNo}";
                }
            }
        }
    }
}

