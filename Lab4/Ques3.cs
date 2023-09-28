using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Ques3
    {
     
public class Product
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public double Price { set; get; }
        public string[] Colors { set; get; }
        public int Brand { set; get; }

        public Product(int id, string name, double price, string[] colors, int brand)
        {
            ID = id;
            Name = name;
            Price = price;
            Colors = colors;
            Brand = brand;
        }

        public override string ToString()
        {
            return $"{ID,3} {Name,-12} {Price,5} {Brand,2} {string.Join(", ", Colors)}";
        }
    }

    public class Brand
    {
        public string Name { set; get; }
        public int ID { set; get; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Initialize the products list
            List<Product> products = new List<Product>
        {
            new Product(1, "Product A", 400, new[] { "Red", "Blue" }, 101),
            new Product(2, "Product B", 500, new[] { "Green", "Yellow" }, 102),
            new Product(3, "Product C", 600, new[] { "Red", "Yellow" }, 101),
            new Product(4, "Product D", 700, new[] { "Blue", "Green" }, 103),
        };

            // Initialize the brands list
            List<Brand> brands = new List<Brand>
        {
            new Brand { ID = 101, Name = "Brand X" },
            new Brand { ID = 102, Name = "Brand Y" },
            new Brand { ID = 103, Name = "Brand Z" },
        };

            // LINQ Query: Filter products with a price of 400
            var price400Products = products.Where(p => p.Price == 400);

            // LINQ Query: Filter products that contain the color yellow
            var yellowProducts = products.Where(p => p.Colors.Contains("Yellow"));

            // LINQ Query: Display products in descending order of price
            var descendingPriceProducts = products.OrderByDescending(p => p.Price);

            // Print the results
            Console.WriteLine("Products with price 400:");
            foreach (var product in price400Products)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine("\nProducts with color Yellow:");
            foreach (var product in yellowProducts)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine("\nProducts in descending order of price:");
            foreach (var product in descendingPriceProducts)
            {
                Console.WriteLine(product);
            }
        }
    }

}
}
