namespace ClassStudies
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Jon = new Person();
            Jon.Age = 29;
            Jon.Name = "Jon";


            System.Console.Write(Jon.Age);
            System.Console.ReadKey();
        }
    }
}
