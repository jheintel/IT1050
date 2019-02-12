using IO = System.Console;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create 2 Instructors and give 'em a class
            Instructor iJohn = new Instructor("John", "English");
            Instructor iMike = new Instructor("Mike", "Math");

            // Originally students were called s1 - s4 but that got hard to read
            Student sJane = new Student("Jane", iJohn);
            Student sJoe = new Student("Joe", iJohn);
            Student sMel = new Student("Melissa", iMike);
            Student sMat = new Student("Matt", iMike);

            // Have the Instructors assign their students grades
            iJohn.SetStudentGrade(sJane, 95);
            iJohn.SetStudentGrade(sJoe, 85);
            iMike.SetStudentGrade(sMel, 90);
            iMike.SetStudentGrade(sMat, 92);
            //iMike.SetStudentGrade(sJane, 45);

            // Print to the console
            IO.WriteLine();
            sJane.PrintInfoSpaced();
            sJoe.PrintInfoSpaced();
            sMel.PrintInfoSpaced();
            sMat.PrintInfoSpaced();

            // Sit on our thumbs until, ideally, the heat death of the universe
            IO.Write("Press any key to end existance...");
            IO.ReadKey();
        }
    }
}
