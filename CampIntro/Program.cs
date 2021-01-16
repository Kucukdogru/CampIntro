using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği
            //Do not repeat yourself  - Kendini tekrarlama
            //değer tututcu, alias

            string categoryTitle = "Kategori";
            int studentNumber = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarbUGUN = 7.45;


            if (dolarDun>dolarbUGUN)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if(dolarDun<dolarbUGUN)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("eşittir butonu");
            }



            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            Console.WriteLine(categoryTitle);
        }
    }
}
