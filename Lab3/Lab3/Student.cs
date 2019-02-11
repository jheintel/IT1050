using IO = System.Console;

namespace Lab3
{
    class Student
    {
        private string Name;
        private Instructor Teacher;
        private int Grade;

        public Student()
        {
            Name = "Unknown";
            
            Grade = 0;
        }

        public Student(string givenName, Instructor givenInstructor)
        {
            Name = givenName;
            Teacher = givenInstructor;
            Grade = 0;
        }

        public void SetGrade(int givenGrade)
        {
            Grade = givenGrade;
        }

        public void PrintInfo()
        {
            IO.Write("Student Name: ");
            IO.WriteLine(Name);
            IO.Write("Grade: ");
            IO.WriteLine(Grade);
            Teacher.PrintNameAndCourse();
        }
    }
}
