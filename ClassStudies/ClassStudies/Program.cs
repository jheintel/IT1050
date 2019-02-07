using System;

namespace ClassStudies
{
    class Program
    {
        static void Main(string[] args)
        {
            int numStudents = 0;
            Teacher.Count = 0;

            Teacher theTeacher = new Teacher();
            theTeacher.Name = "Boss Baby";
            Teacher.Count++;

            Student student1 = new Student();
            student1.Name = "Coolio Hernandas";
            student1.Grade = "B";
            numStudents++;

            Student student2 = new Student();
            student2.Name = "Cardi B";
            student2.Grade = "A";
            numStudents++;


            System.Console.WriteLine("Teachers: " + Teacher.Count);
            System.Console.WriteLine("Students: " + numStudents);
            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();
        }
    }
}
