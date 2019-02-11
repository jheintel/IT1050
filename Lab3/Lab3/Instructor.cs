using IO = System.Console;

namespace Lab3
{
    class Instructor
    {
        private string Name;
        private string CourseName;

        public Instructor()
        {
            Name = "Missing Instructor";
            CourseName = "Missing Course";
        }

        public Instructor(string givenName, string givenCourseName)
        {
            Name = givenName;
            CourseName = givenCourseName;
        }

        public void SetStudentGrade(Student givenStudent, int newGrade)
        {
            givenStudent.SetGrade(newGrade);
        }

        public void PrintNameAndCourse()
        {
            IO.Write("Instructor: ");
            IO.WriteLine(Name);
            IO.Write("Course: ");
            IO.WriteLine(CourseName);    
        }
    }
}
