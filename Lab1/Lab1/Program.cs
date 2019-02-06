using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName,
                   middleInitial,
                   LastName,
                   fullName;
            int age = 0;
            string isCitizenAnswer;
            bool isCitizen = false;
            bool canVote = false;
            int heightFeet = 0;
            double heightInches = 0.0;
            double totalHeightCM = 0.0;

            // Asks user for a name then truncates the answers into fullName
            {
                Console.Write("What is your first name?: ");
                firstName = Console.ReadLine();
                Console.Write("What is your middle initial?: ");
                middleInitial = Console.ReadLine() + ".";
                Console.Write("What is your last name?: ");
                LastName = Console.ReadLine();

                fullName = firstName + " " + middleInitial + " " + LastName;
            }

            /* Asks for the users height in feet and inches then converts it to some voodoo number
            that is yet to be understood by our engineers. */
            {
                Console.Write("How many feet tall are you (excluding inches using numerals)?: ");
                heightFeet = int.Parse(Console.ReadLine());
                Console.Write("and how many inches beyond that?(Decimal): ");
                heightInches = double.Parse(Console.ReadLine());

                totalHeightCM = (heightFeet * 12 + heightInches) * 2.54;
            }

            // Some personal questions for border security reasons
            {
                Console.Write("How old are you?: ");
                age = int.Parse(Console.ReadLine());

                Console.Write("Are you a citizen y or n?: ");
                isCitizenAnswer = Console.ReadLine();
                isCitizen = isCitizenAnswer.Contains("y") || isCitizenAnswer.Contains("Y");

                canVote = isCitizen && (age >= 18);
            }

            // Print the whole mess out and hope the client doesn't look to closely at our methods
            {
                Console.WriteLine();

                Console.Write("So... \n" + "Your name is " + fullName + "\n" +
                              "You are " + totalHeightCM + "cm tall \n");
                if (canVote)
                    Console.Write("and you are eligible to vote \n");
                else
                    Console.Write("and you are not eligible to vote \n");
                Console.WriteLine();
            }

            Console.Write("press any key to close window.");
            Console.ReadKey();
        }
    }
}
