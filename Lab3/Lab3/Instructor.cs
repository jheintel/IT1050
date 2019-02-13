namespace Lab3
{
    class Instructor
    {
        private readonly string Name;
        private readonly string CourseName;

        /* Please don't use
         * I would need to add methods SetName and SetCourseName if this is ever called
         * which would violate the readonly variables. Having this constructor is just
         * bad code, really.
         */
        public Instructor()
        {
            Name = "Missing Instructor";
            CourseName = "Missing Course";
            Show.InstructorCreationMessage(Name, CourseName);
        }

        // Instructor Constructor
        public Instructor(string givenName, string givenCourseName)
        {
            Name = givenName;
            CourseName = givenCourseName;
            Show.InstructorCreationMessage(givenName, givenCourseName);
        }

        // Method will only allow Students' Instructors to change grade
        // as opposed to any Instructor.
        public void SetStudentGrade(Student givenStudent, int newGrade)
        {
            if (givenStudent.GetInstructor().GetName() == Name)
                givenStudent.Grade = newGrade;
            else
                Show.Format("Student is not in " + Name + "'s class");
        }

        public string GetName()
        {
            return Name;
        }

        public string GetCourse()
        {
            return CourseName;
        }
    }
}
