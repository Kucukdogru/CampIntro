using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Class olduğu için newlemek lazım

            Product product1 = new Product();
            product1.ProductName = "Apple";
            product1.Price = 15;
            product1.Description = "Apple of Amasya";

            Product product2 = new Product();
            product2.ProductName = "Watermelon";
            product2.Price = 80;
            product2.Description = "Diyarbakır Karpuzu";

            Product[] products = new Product[] { product1, product2 };

            //Type safe -- tip güvenli
            foreach (Product product in products)
            {
                Console.WriteLine(product.ProductName);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
                Console.WriteLine("****************************");
            }


            Console.WriteLine("********************Metotlar****************");
            //instance - örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);


            sepetManager.Add2("Armut", "Yeşil armut", 12, 5);
        }
    }
}


//16.01.2021
// Dont repeat yourself - Kendini tekrar etme - DRY - Clean Code - Best Practice - Doğru Uygulama Teknikleri