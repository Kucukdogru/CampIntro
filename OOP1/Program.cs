using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product
            {
                Id = 2,
                CategoryId =5,
                UnitsInStock=5,
                ProductName="Kalem",
                UnitPrice=35
            };

            //instance
            //PascalCase  //camelCase
            //case sensitive
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            //productManager.Sum2(3, 6);

            //int result = productManager.Sum(3, 6);

            //Console.WriteLine(result*2);

        }
    }
}
