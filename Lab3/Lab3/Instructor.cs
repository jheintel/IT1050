using IO = System.Console;

namespace Lab3
{
    class Instructor
    {
        private string Name;
        private string CourseName;

        // Please don't use
        // I would need to add methods to change Name and CourseName if this is ever called
        public Instructor()
        {
            Name = "Missing Instructor";
            CourseName = "Missing Course";
        }

        // Instructor Constructor
        public Instructor(string givenName, string givenCourseName)
        {
            Name = givenName;
            CourseName = givenCourseName;
            IO.Write("Instructor " + givenName + " added ");
            IO.WriteLine("instructing " + givenCourseName);
        }

        // Method will only allow Students' Instructors to change grade
        // as opposed to any Instructor.
        public void SetStudentGrade(Student givenStudent, int newGrade)
        {
            if (givenStudent.GetInstructor().GetName() == Name)
                givenStudent.SetGrade(newGrade);
            else
                IO.WriteLine("Student is not in " + Name + "'s class");
        }

        public string GetName()
        {
            return Name;
        }

        public string GetCourse()
        {
            return CourseName;
        }

        // Two Methods to print because I wanted carriage returns, but only sometimes
        public void PrintNameAndCourse()
        {
            IO.Write("Instructor: ");
            IO.WriteLine(Name);
            IO.Write("Course: ");
            IO.WriteLine(CourseName);    
        }

        public void PrintNameAndCourseSpaced()
        {
            IO.Write("Instructor: ");
            IO.WriteLine(Name);
            IO.Write("Course: ");
            IO.WriteLine(CourseName);
            IO.WriteLine();
        }
    }
}
