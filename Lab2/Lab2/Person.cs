using IO = System.Console;

namespace Lab2
{
    class Person
    {
        public int Age;
        public string FirstName;
        public string Lastname;
        public bool Married;
        public Person Spouse;

        public static int NumberOfPeople = 0;
        public static int SumOfAges;


        public string GetFullName()
        {
            string fullName = "";
            fullName += Lastname;
            fullName += ", ";
            fullName += FirstName;
            return fullName;
        }

        public void PrintNameAndAge()
        {
            if (FirstName != "None")
                IO.WriteLine(GetFullName() + " (" + Age + ") ");
        }

        public void AskForPerson()
        {
            int ageAssign = 0;
            NumberOfPeople++;
            Spouse = new Person();

            IO.Write("Enter Your First Name             :");
            FirstName = IO.ReadLine();
            IO.Write("Enter Your Last Name              :");
            Lastname = IO.ReadLine();
            IO.Write("Enter Your Age                    :");
            ageAssign = int.Parse(IO.ReadLine());
            SumOfAges += ageAssign;
            Age = ageAssign;

            IO.Write("Are You Married (y or n)?         :");
            Married = IO.ReadLine().ToLower().Contains("y");
            if (Married)
            {
                NumberOfPeople++;
                IO.Write("Enter Your Spouse's First Name    :");
                Spouse.FirstName = IO.ReadLine();
                Spouse.Lastname = Lastname;
                IO.Write("Enter Your Spouse's Age           :");
                ageAssign = int.Parse(IO.ReadLine());
                SumOfAges += ageAssign;
                Spouse.Age = ageAssign;
            }
            else
            {
                Spouse.FirstName = "None";
                Spouse.Lastname = "None";
                Spouse.Age = 0;
            }

            Spouse.Spouse = this;

            IO.WriteLine();
        }

        public static double AvgerageAge()
        {
            double average = 0.0;
            average += SumOfAges;
            average /= NumberOfPeople;
            return average;
        }
    }
}