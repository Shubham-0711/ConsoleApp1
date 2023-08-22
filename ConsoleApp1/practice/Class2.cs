using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.practice
{


    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Product ID: {Id}\nName: {Name}\nPrice: {Price:C}";
        }

        public void ApplyDiscount(decimal discountPercentage)
        {
            if (discountPercentage < 0 || discountPercentage > 100)
            {
                throw new ArgumentException("Discount percentage must be between 0 and 100.");
            }

            decimal discountAmount = Price * (discountPercentage / 100);
            decimal discountedPrice = Price - discountAmount;

            Console.WriteLine($"Actual Price: {Price:C}");
            Console.WriteLine($"Discounted Price: {discountedPrice:C}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Creating a product using object initializer syntax
            Product product = new Product
            {
                Id = 1,
                Name = "Example Product",
                Price = 50.00M
            };

            Console.WriteLine(product.ToString());

            Console.Write("Enter discount percentage: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal discountPercentage))
            {
                product.ApplyDiscount(discountPercentage);


            }
        }
    }
}
