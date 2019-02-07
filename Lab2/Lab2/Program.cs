using IO = System.Console;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person();

            IO.WriteLine("[ Enter Information for p1 ]\n");
            p1.AskForPerson();
            IO.WriteLine("[ Enter Information for p2 ]\n");
            p2.AskForPerson();

            p1.PrintNameAndAge();
            p1.Spouse.PrintNameAndAge();
            p2.PrintNameAndAge();
            p2.Spouse.PrintNameAndAge();
            IO.WriteLine();
            
            IO.WriteLine("Average Age = " + Person.AvgerageAge());
            IO.WriteLine();

            IO.Write("Press any key to continue...");
            IO.ReadKey();
        }
    }
}