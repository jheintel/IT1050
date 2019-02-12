using IO = System.Console;

namespace Lab3
{
    class Student
    {
        private string Name;
        private Instructor Teacher;
        private int Grade;
        
        // Can I just set Teacher = null? It feels wrong...
        public Student()
        {
            Name = "Unknown";
            Teacher = null; 
            Grade = 0;
        }

        // Creates and reports to console a new Student
        public Student(string givenName, Instructor givenInstructor)
        {
            Name = givenName;
            Teacher = givenInstructor;
            Grade = 0;

            IO.Write("Student " + givenName + " has joined ");
            IO.WriteLine(givenInstructor.GetName() + "'s " + givenInstructor.GetCourse() + " class");
        }

        // Changes Students grade and I feel like I'm over commenting
        public void SetGrade(int givenGrade)
        {
            Grade = givenGrade;
        }

        // Used to determine if Instructor can change Students' grades in a roundabout
        // way inside the Instructor class. There might be a better way but I didn't
        // find one yet.
        public Instructor GetInstructor()
        {
            return Teacher;
        }

        // Print out some stuff from the void and all hail Cthulhu ehrupjwecniwinpmwpecino
        public void PrintInfo()
        {
            IO.Write("Student Name: ");
            IO.WriteLine(Name);
            IO.Write("Grade: ");
            IO.WriteLine(Grade);
            Teacher.PrintNameAndCourse();
        }

        public void PrintInfoSpaced()
        {
            IO.Write("Student Name: ");
            IO.WriteLine(Name);
            IO.Write("Grade: ");
            IO.WriteLine(Grade);
            Teacher.PrintNameAndCourse();
            IO.WriteLine();
        }
    }
}
