using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.collection.grc_coll
{
    public class Emplloyee
    {
        public string name { get; set; }
        public int salary { get; set; }
    }
    public class CheckSalary:IComparer<Emplloyee>
    {
        public int Compare(Emplloyee x, Emplloyee y)
        {
            if (x.salary >y.salary)
            {
                return 1;
            }
            else if(x.salary <y.salary)
            {
                return -1;

            }
            else
            { 
                return 0;
            }
        }
    }


    public class prg
    {

        static void Main(string[] args)
        {
            Emplloyee e1 = new Emplloyee { name = "suresh", salary = 25000 };
            Emplloyee e2 = new Emplloyee { name = "sahil", salary = 25000 };

            CheckSalary c = new CheckSalary();

            int result = c.Compare(e1, e2);

            if (result == 1)
            {
                Console.WriteLine("e1 hashigher salary than e2 ");
            }
            else if (result == -1)
            {
                Console.WriteLine("e1 has less salary than e2 ");

            }
            else
            {
                Console.WriteLine("e1 and e2 has equal salry ");
            }
        }
        

    }

    
}
