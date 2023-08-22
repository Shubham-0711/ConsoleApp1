using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
        public class Base
        {
            protected int Roll_no;
            protected string Name;
            public Base(int Roll_no, string Name)
            {
                this.Roll_no = Roll_no;
                this.Name = Name;
            }
            public virtual string Display()
            {
                return $"{Roll_no} {Name}";
            }
        }
        public class c1 : Base
        {
        int id;
            public c1(int id,int Roll_no, string Name) : base(Roll_no, Name)
            {
                this.id=id;
            }
            public override string Display()
            {
                return $"{id},{Roll_no},{Name}";
            }
        }
    }

