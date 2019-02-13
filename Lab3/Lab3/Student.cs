namespace Lab3
{
    class Student
    {
        private readonly string Name;
        private readonly Instructor Teacher;
        /* I was digging around in C# Guides after Visual Studio told me there was a better way
         * so _grade is coded as a "property" but I left the others as originally written
         */
        private int _grade;
        
        // Can I just set Teacher = null? It feels wrong...
        public Student()
        {
            Name = "Unknown";
            Teacher = null; 
            _grade = 0;
        }

        // Creates and reports to console a new Student
        public Student(string givenName, Instructor givenInstructor)
        {
            Name = givenName;
            Teacher = givenInstructor;
            _grade = 0;
            Show.StudentCreationMessage(givenName, givenInstructor);
        }

        // Used to determine if Instructor can change Students' grades in a roundabout
        // way inside the Instructor class. There might be a better way but I didn't
        // find one yet.
        public Instructor GetInstructor()
        {
            return Teacher;
        }

        public string GetName()
        {
            return Name;
        }

        public int Grade
        {
            get => _grade;
            set
            {
                _grade = value;
                Show.GradeChangeMessage(Teacher, this, _grade);
            }
        }
    }
}
