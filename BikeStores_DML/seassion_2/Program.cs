using Microsoft.EntityFrameworkCore;
using seassion_2.Data;

namespace seassion_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext context = new ApplicationDbContext();

            Console.WriteLine("================ Retrieve all categories from the production.categories table.] =============");
            var cats = context.Categories.ToList();

            foreach (var cat in cats)
            {
                Console.WriteLine($"Id {cat.CategoryId}, Name: {cat.CategoryName}");
            }

            Console.WriteLine("\n================ Retrieve the first product from the production.products table. =============");

            var product = context.Products.First();
            Console.WriteLine($"ID: {product.ProductId}, Name: {product.ProductName}");

            Console.WriteLine("\n================ Retrieve a specific product from the production.products table by ID. =============");
            
            var product2 = context.Products.FirstOrDefault(p => p.ProductId == 15);
            Console.WriteLine($"ID: {product2.ProductId}, Name: {product2.ProductName}");

            Console.WriteLine("\n================ Retrieve all products from the production.products table with a certain model year. =============");
            
            var allProducts = context.Products.Where(p => p.ModelYear == 2019);
            foreach (var p in allProducts)
            {
                Console.WriteLine($"Id {p.ProductId}, Name: {p.ProductName}, Model Year: {p.ModelYear}");
            }

            Console.WriteLine("\n================ Retrieve a specific customer from the sales.customers table by ID. =============");

            var customer = context.Customers.Find(22); // Method 1
            var customer2 = context.Customers.Where(c => c.CustomerId == 22); // Method 2

            Console.WriteLine($"Id {customer.CustomerId}, Name: {customer.FirstName}, City: {customer.City}");

            foreach (var c in customer2)
            {
                Console.WriteLine($"Id {c.CustomerId}, Name: {c.FirstName}, City: {c.City}");
            }

            Console.WriteLine("\n================ Retrieve a list of product names and their corresponding brand names. =============");

            var productWithBrand = context.Products.Include(p => p.Brand).Select(p => new
            {
                productName = p.ProductName,
                BrandName = p.Brand.BrandName
            });

            foreach(var pwb in productWithBrand)
            {
                Console.WriteLine($"ProductName: {pwb.productName}, BrandName: {pwb.BrandName}");
            }

            Console.WriteLine("\n================ Count the number of products in a specific category. =============");

            var productWithCategory = context.Categories.Include(c => c.Products);

            foreach (var pwc in productWithCategory)
            {
                Console.WriteLine($"Category Name: {pwc.CategoryName}, Number Of Products: {pwc.Products.Count()}");
            }

            Console.WriteLine("\n================ Calculate the total list price of all products in a specific category. =============");

            var productWithCategory2 = context.Categories.Include(c => c.Products);

            foreach (var pwc in productWithCategory2)
            {
                Console.WriteLine($"Category Name: {pwc.CategoryName}, list price Of Products: {pwc.Products.Sum(p => p.ListPrice)}");
            }

            Console.WriteLine("\n================ Calculate the average list price of products. =============");

            var avgProducts = context.Products.Average(e => e.ListPrice);
            Console.WriteLine(avgProducts);

            Console.WriteLine("\n================ Retrieve orders that are completed.. =============");

            var completedOrders = context.Orders.Where(o => o.OrderStatus == 4);

            foreach (var o in completedOrders)
            {
                Console.WriteLine($"Order ID: {o.OrderId}, Order Status: {o.OrderStatus}");
            }

            Console.ReadKey();
        }
    }
}