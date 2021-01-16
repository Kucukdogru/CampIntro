using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //bu course1, course2, course3 hepsi ayrı ayrı bir değişken
            Course course1 = new Course();
            course1.CourseName = "C#";
            course1.Educator = "Engin Demiroğ";
            course1.WatchRate = 68;


            Course course2 = new Course();
            course2.CourseName = "Python";
            course2.Educator = "Engin Demiroğ";
            course2.WatchRate = 75;

            Course course3 = new Course();
            course3.CourseName = "Java";
            course3.Educator = "Engin Demiroğ";
            course3.WatchRate = 45;

            Course course4 = new Course();
            course4.CourseName = "T-Sql/Pl/Sql";
            course4.Educator = "Merve KÜÇÜKDOĞRU";
            course4.WatchRate = 45;

            //Console.WriteLine(course1.CourseName+ " : " + course1.Educator);


            Course[] courses = new Course[]{course1, course2, course3};

            foreach (var course in courses)
            {
                //Console.WriteLine(course.CourseName);
                Console.WriteLine(course.CourseName + " : " + course.Educator);
            }

        }
    }

    class Course
    {
        public string CourseName { get; set; }

        public string Educator { get; set; }

        public int WatchRate { get; set; }
    }
}
