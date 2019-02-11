using IO = System.Console;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            // This program needs comments

            Instructor i1 = new Instructor("John", "English");
            Instructor i2 = new Instructor("Mike", "Math");

            Student s1 = new Student("Jane", i1);
            Student s2 = new Student("Joe", i1);
            Student s3 = new Student("Melissa", i2);
            Student s4 = new Student("Matt", i2);

            i1.SetStudentGrade(s1, 95);
            i1.SetStudentGrade(s2, 85);
            i2.SetStudentGrade(s3, 90);
            i2.SetStudentGrade(s4, 92);

            s1.PrintInfo();
            IO.WriteLine();
            s2.PrintInfo();
            IO.WriteLine();
            s3.PrintInfo();
            IO.WriteLine();
            s4.PrintInfo();
            IO.WriteLine();

            IO.Write("Press any key to continue...");
            IO.ReadKey();
        }
    }
}
