using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Catgeory> categories = new List<Catgeory>
            {
                new Catgeory{CategoryId=1, CategoryName="Bilgisayar"},
                new Catgeory{CategoryId=2, CategoryName="Telefon"}
            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId=1, CategoryId=1, ProductName="Acer Laptop", QuantityPerUnit="32 GB Ram", UnitPrice=1000, UnitsInStock=5},
                new Product{ProductId=2, CategoryId=1, ProductName="ASUS Laptop", QuantityPerUnit="16 GB Ram", UnitPrice=8000, UnitsInStock=3},
                new Product{ProductId=3, CategoryId=1, ProductName="HP Laptop", QuantityPerUnit="8 GB Ram", UnitPrice=6000, UnitsInStock=6},
                new Product{ProductId=4, CategoryId=2, ProductName="SAMSUMG Telefon", QuantityPerUnit="4 GB Ram", UnitPrice=6000, UnitsInStock=15},
                new Product{ProductId=5, CategoryId=2, ProductName="APPLE Telefon", QuantityPerUnit="8 GB Ram", UnitPrice=8000, UnitsInStock=0},
            };
            //LinqListMethods(products);

            //WriteGetProducts(products);

            //WriteGetProductsLinq(products);

            //AnyTest(products);

            //FindTest(products);

            //FindAllTest(products);

            //OrderByAscendingTest(products);

            //OrderByDescendingTest(products);

            //LinqFromTest(products);

            //LinqWhereTest(products);

            //LinqSelectTest(products);

            //ClassicLinqTest(products);


            var result = from p in products
                         join
                         c in categories
                         on p.CategoryId equals c.CategoryId
                         where p.UnitPrice>5000
                         orderby p.UnitPrice descending
                         select new ProductDetailDto { ProductId = p.ProductId, CategoryName = c.CategoryName, ProductName = p.ProductName, UnitPrice = p.UnitPrice };

            foreach (var productDetailDto in result)
            {
                Console.WriteLine("{0} -- {1}", productDetailDto.ProductName, productDetailDto.CategoryName);
            }
                         
        }

        private static void ClassicLinqTest(List<Product> products)
        {
            var result = from p in products
                         where p.UnitPrice >= 3500 && p.QuantityPerUnit.Contains("GB")
                         orderby p.UnitPrice descending
                         select new ProductDetailDto { ProductId = p.ProductId, ProductName = p.ProductName, UnitPrice = p.UnitPrice };

            foreach (var product in result)
            {
                Console.WriteLine(product);
            }
        }

        private static void LinqSelectTest(List<Product> products)
        {
            var result = from p in products
                         where p.UnitPrice >= 3500 && p.QuantityPerUnit.Contains("GB")
                         orderby p.UnitPrice descending
                         select p.ProductName;

            foreach (var product in result)
            {
                Console.WriteLine(product);
            }
        }

        private static void LinqWhereTest(List<Product> products)
        {
            var result = from p in products
                         where p.UnitPrice > 3000 && p.UnitsInStock > 3
                         orderby p.UnitPrice descending, p.ProductName ascending
                         select p;

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void LinqFromTest(List<Product> products)
        {
            var result = from p in products
                         select p;

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void OrderByDescendingTest(List<Product> products)
        {
            var result = products.Where(p => p.ProductName.Contains("top")).OrderByDescending(p => p.UnitPrice).ThenByDescending(p => p.ProductName);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void OrderByAscendingTest(List<Product> products)
        {
            var result = products.Where(p => p.ProductName.Contains("top")).OrderBy(p => p.UnitPrice);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void FindAllTest(List<Product> products)
        {
            var result = products.FindAll(p => p.ProductName.Contains("top"));
            Console.WriteLine(result);
        }

        private static void FindTest(List<Product> products)
        {
            var result = products.Find(p => p.ProductId == 3);
            Console.WriteLine(result.ProductName);
            Console.WriteLine(result.QuantityPerUnit);
            Console.WriteLine(result.UnitPrice);
        }

        private static void AnyTest(List<Product> products)
        {
            var result = products.Any(p => p.ProductName == "Acer Laptop");
            Console.WriteLine(result);
        }

        private static void LinqListMethods(List<Product> products)
        {
            Console.WriteLine("*******************Algoritmik********************");

            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
                {
                    Console.WriteLine(product.ProductName);
                }

            }

            Console.WriteLine("**********************LINQ***********************");

            // LINQ
            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void WriteGetProducts(List<Product> products)
        {
            Console.WriteLine("**********************GetProducts***********************");


            var list = GetProducts(products);
            foreach (var item in list)
            {
                Console.WriteLine(item.ProductName);
            }
        }

        private static void WriteGetProductsLinq(List<Product> products)
        {
            Console.WriteLine("******************GetProductsLinq*******************");

            var linq = GetProductsLinq(products);
            foreach (var item in linq)
            {
                Console.WriteLine(item.ProductName);
            }
        }

        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
                {
                    filteredProducts.Add(product);
                }

            }
            return filteredProducts;
        }

        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3).ToList(); 
        }
    }
}
