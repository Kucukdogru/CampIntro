using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

        //public int Sum(int number1, int number2)
        //{
        //    return number1 + number2;
        //}

        //public void Sum2(int number1, int number2)
        //{
        //    Console.WriteLine(number1+number2);
        //}


    }
}
