using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array
{   
        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Price { get; set; }

        }

        public class Program
        {
            static void Main(string[] args)
            {
                Product[] list = new Product[3]
                {
                new Product{Id=1,Name = "pen", Price=20},
                new Product{Id=2,Name = "Bag", Price=300},
                new Product{Id=3,Name = "pencil" ,Price=20}
                };

                foreach (Product p in list)
                {
                    Console.WriteLine($"{p.Id} {p.Name} {p.Price}");
                }
            }
        }
    
}
