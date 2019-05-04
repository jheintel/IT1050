using IO = System.Console;

namespace Lab4
{
    class Show
    {
        private const int windowX = 50;
        private const int windowY = 20;

        public static void TitleCard()
        {
            IO.SetWindowSize(windowX, windowY);
            Show.Write("             _   _ _       _     _           _   \n" +
                     "     /\\     | \\ | (_)     | |   | |         | |\n" +
                     "    /  \\    |  \\| |_  __ _| |__ | |_    __ _| |_\n" +
                     "   / /\\ \\   | . ` | |/ _` | '_ \\| __|  / _` | __|\n" +
                     "  / ____ \\  | |\\  | | (_| | | | | |_  | (_| | |_  \n" +
                     " /_/    \\_\\ |_| \\_|_|\\__, |_| |_|\\__|  \\__,_|\\__|\n" +
                     "                      __/ |                     \n" +
                     "  _   _            __|___/           _           \n" +
                     " | | | |          |  \\/  |          (_)          \n" +
                     " | |_| |__   ___  | \\  / | _____   ___  ___  ___\n" +
                     " | __| '_ \\ / _ \\ | |\\/| |/ _ \\ \\ / / |/ _ \\/ __|\n" +
                     " | |_| | | |  __/ | |  | | (_) \\ V /| |  __/\\__ \\ \n" +
                     "  \\__|_| |_|\\___| |_|  |_|\\___/ \\_/ |_|\\___||___/  \n");
            Show.WriteLine();
            Show.Divider();
            Show.PrintCentered("Press any key to continue");
            IO.ReadKey();
            Show.Clear();
        }

        public static void FinalTotals()
        {
            Show.Clear();
            Show.PrintCentered("Your total will be $" + (Tickets.TotalTicketCost + Concessions.TotalConcessionsCost));
            Show.WriteLine();
            Show.PrintCentered("Press any key to exit");
            IO.ReadKey();
        }

        public static void Divider()
        {
            int countdown = IO.WindowWidth;
            IO.Write("+");
            while (countdown > 2)
            {
                IO.Write("-");
                countdown--;
            }
            IO.WriteLine("+");
        }

        public static void PrintCentered(string toBeCentered)
        {
            IO.SetCursorPosition((windowX - toBeCentered.Length) / 2, IO.CursorTop);
            IO.Write(toBeCentered);
        }

        public static void Write(string toWrite)
        {
            IO.Write(toWrite);
        }

        public static void WriteLine(string toWrite)
        {
            IO.WriteLine(toWrite);
        }

        public static void WriteLine()
        {
            IO.WriteLine();
        }

        public static string ReadLine()
        {
            return IO.ReadLine();
        }

        public static void Clear()
        {
            IO.Clear();
        }

        public static int KeyInfoInt()
        {
            int val = 0;
            val = int.Parse(IO.ReadKey().KeyChar.ToString());
            return val;
        }

    }
}
