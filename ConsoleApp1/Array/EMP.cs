using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array
{
   public class EMP
    {
        public int empId {get;set; }
        public string empName { get;set; }
        public int Salary{ get;set; }
       
    }
    
    public class Programe
    {
        static void Main(string[] args)
        {
            EMP[] emp = new EMP[2];
            
              emp[0]=  new EMP { empId = 1,empName="Sandesh",Salary=30};
                emp[1]=new EMP { empId = 2, empName = "Rohit", Salary= 40 };   
            
            foreach (EMP E in emp) 
            {
                Console.WriteLine(  E.empId+" "+E.empName);
                //Console.WriteLine($"{E.empId}{E.empName}{E.Salary}");
            }
        }
    }
}
