namespace ClassStudies
{
    class Teacher
    {
        public string Name;

        public static int Count; // Does not exist on the instance object. Exists on the class

        public static void HelloWorld()
        {
            System.Console.WriteLine("Hello World");
        }
    }
}
