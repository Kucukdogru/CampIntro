using System;

namespace ValueandReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;

            Console.WriteLine(sayi1);  //30

            int[] numbers1 = new int[] { 10, 20, 30 };
            int[] numbers2 = new int[] { 100, 200, 300};

            numbers1 = numbers2;

            numbers2[0] = 999;
            Console.WriteLine(numbers1[0]); //999
        }
    }
}
