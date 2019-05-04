using IO = System.Console;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Show.TitleCard();

            Tickets.WhatTime();
            Tickets.WhosGoing();

            Concessions.WhatToEat();

            Show.FinalTotals();
        }
    }
}
