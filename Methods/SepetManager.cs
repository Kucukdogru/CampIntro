using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        //naming convention
        //syntax

        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler!!! Sepete eklendi : " + product.ProductName);
        }

        public void Add2(string productName, string description, double price, int stockQuantity)
        {
            Console.WriteLine("Tebrikler!!! Sepete eklendi : " + productName);
        }
    }
}
