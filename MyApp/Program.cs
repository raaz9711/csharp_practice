// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using MyApp;

List<Product> products = new List<Product>()
{
    new Product(){Name = "Laptop" , Price = 40000},
    new Product(){Name = "Watch" , Price = 10000}
};

foreach(Product product in products)
    System.Console.WriteLine(product.ToString());

products.Sort(new ProductComparer());

System.Console.WriteLine("----------------------");

foreach(Product product in products)
    System.Console.WriteLine(product.ToString());
