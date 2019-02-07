namespace ClassStudies
{
    class Person
    {
        // Member variable declaration (Instance variable)

        public string FirstName;
        public string MiddleInitial;
        public string LastName;
        public int Age;

        public string GetFullName()
        {
            return FirstName + " " + MiddleInitial + ". " + LastName;
        }

    }
}
