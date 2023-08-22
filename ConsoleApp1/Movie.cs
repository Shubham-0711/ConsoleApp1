using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Movie
    {
        int mid;
        string Mname;
        string Type;
        int t_price;
        int no_of_tickets;
        int available;
        int total_cost;
        int num;

        public Movie(int mid,string mname,int t_price,int no_of_tickets )
        {
            this.mid = mid;
            this.Mname = mname;
            this.t_price = t_price;
            this .no_of_tickets = no_of_tickets;

        }
        public void DisplayMovie()
        {
            Console.WriteLine(mid+"  "+Mname+"  "+t_price+"  "+no_of_tickets);

        }
        public void FindAvailableTickets()
        {
            Console.WriteLine( "Enter no. of ticket to book" );
            num=int.Parse( Console.ReadLine());
            if (no_of_tickets > num)
            {
                available = no_of_tickets - num;
                Console.WriteLine(available);
                this.CalculateticketsCost();
            }
            else
            {
                Console.WriteLine("Not Available !!!");
            }
        }
        public void CalculateticketsCost()
        {
            Console.WriteLine( "1.Silver -100rs" );
            Console.WriteLine( "2.Gold -200rs" );
            Console.WriteLine("3.platinum -300rs");

            Console.WriteLine("Enter your choice =");
            int choice=int.Parse ( Console.ReadLine());

            switch (choice)
            {
                case 1:
                    {
                        Type = "Silver";
                        t_price = 100;
                        break;
                    }
                case 2:
                    {
                        Type = "Gold";
                        t_price = 200;
                        break;
                    }
                case 3:
                    {
                        Type = "Plantinum";
                        t_price = 300;
                        break;
                    }
            }
            total_cost = num * t_price;
            Console.WriteLine(total_cost  );
        }
        public void Details()
        {
            Console.WriteLine("Movie Name" + Mname+"type"+Type+"Booking Tickets"+num+"Total Cost"+total_cost); 
        }

    }
}



    
