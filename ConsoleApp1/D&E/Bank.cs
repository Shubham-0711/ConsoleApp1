using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.D_E
{


    public class prg_bk
    {
        static void Main(string[] args)
        {
            Bank b=new Bank (10000);
            b.Insufficient_bal += delegate () { Console.WriteLine("Insufficient balance :"); };
            b.Low_bal += delegate () { Console.WriteLine("Low balance :"); };
            b.zero_bal += delegate () { Console.WriteLine("Zero balance"); };

            b.credit_amt(4000);
            b.debit_amt(5000);
            b.check_bal();


        }
    }

    public delegate void Mydelegate1();
    
    public class Bank
    {
        public event Mydelegate1 Insufficient_bal;
        public event Mydelegate1 Low_bal;
        public event Mydelegate1 zero_bal;


        public int bal;

        public Bank(int bal)
        {
            this.bal = bal;
        }

        public int credit_amt(int cred_amt)
        {

            bal = bal + cred_amt;
            return bal;

        }

        public int debit_amt(int deb_amt)
        {
            if(bal <deb_amt)
            {
                Insufficient_bal();

            }
            else
            {
                bal=bal- deb_amt;
            }
            return bal;
        }

        public void check_bal()
        {
            if(bal == 0)
            {
                zero_bal();
            }
            else
            {
                Low_bal();
            }

        }
    }
}
