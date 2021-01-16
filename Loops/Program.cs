using System;

namespace Loops
{
    class Program
    {
        //Döngüleri birbirine benzeyen işlemleri tekrar etmek için kullanırız
        //indentetion
        static void Main(string[] args)
        {
            string course1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string course2 = "Programlamaya Başlangıç için temel kurs";
            string course3 = "Java";
            
            //array - dizi

            string[] courses = new string[] {
            "Yazılım Geliştirici Yetiştirme Kampı",
            "Programlamaya Başlangıç için temel kurs",
            "Java",
            "Python",
            "C#"
            };

            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }

            Console.WriteLine("For döngüsü bitti!! ");
            foreach (string course in courses)
            {
                Console.WriteLine(course);
            }

            Console.WriteLine("Sayfa Sonu - Footer");
            
            for (int i = 1; i <= 10; i+=2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
