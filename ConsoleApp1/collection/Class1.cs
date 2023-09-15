using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.collection
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Product p1 = new Product(200, "PEN");
            Product p2 = new Product(400, "BAG");

            int result = p1.CompareTo(p2);

            if (result == 1)
            {
                Console.WriteLine("product price is more than p2");

            }
            else if (result == -1)
            {
                Console.WriteLine("product price is less than p2 ");

            }
            else
            {
                Console.WriteLine("both product price is same");

            }
        }
    }
    public class Product : IComparable
    {
        private int price;
        private string name;

        public Product(int price, string name)
        {
            this.price = price;
            this.name = name;
        }


        public int CompareTo(object obj)
        {
            Product p1 = (Product)obj;

            if (this.price > p1.price)
            {
                return 1;
            }
            else if (this.price < p1.price)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
   


