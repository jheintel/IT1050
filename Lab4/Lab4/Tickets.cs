namespace Lab4
{
    class Tickets
    {
        public static double TotalTicketCost
        {
            get { return totalTicketCost; }
            set { totalTicketCost = value; }
        }
        private static double totalTicketCost;
        public static int NumOfTickets
        {
            get { return numOfTickets; }
            set { numOfTickets = value; }
        }
        private static int numOfTickets;
        private static int TotalChild;
        private static int TotalAdult;
        private static int TotalSenior;
        public static bool Matinee
        {
            get { return matinee; }
            set { matinee = value; }
        }
        private static bool matinee;

        public static void WhatTime()
        {
            Show.Clear();
            string isMatinee = "";
            Show.WriteLine("Would you like to attend a matinee?");

            while (!isMatinee.Contains("y") && !isMatinee.Contains("n"))
            {
                Show.Write("Please enter Y or N:");
                isMatinee = Show.ReadLine().ToLower();
            }

            matinee = ("y" == isMatinee);
        }

        public static void WhosGoing()
        {
            int addTicket = 0;
            const int DONE_ORDERING = 4;

            while (addTicket != DONE_ORDERING)
            {
                Show.Clear();
                Show.WriteLine("Enter a corrisponding number to add a ticket");
                if (matinee)
                {
                    Show.WriteLine("1. Adult $" + Prices.MATINEE_ADULT);
                    Show.WriteLine("2. Child $" + Prices.MATINEE_CHILD);
                    Show.WriteLine("3. Senior $" + Prices.MATINEE_SENIOR);
                    Show.WriteLine("4. Done\n");

                    TicketTally(addTicket);
                }
                else
                {
                    Show.WriteLine("1. Adult $" + Prices.EVENING_ADULT);
                    Show.WriteLine("2. Child $" + Prices.EVENING_CHILD);
                    Show.WriteLine("3. Senior $" + Prices.EVENING_SENIOR);
                    Show.WriteLine("4. Done\n");

                    TicketTally(addTicket);
                }

                Show.Write("You have: " + TotalAdult  + " Adult tickets\n" +
                           "          " + TotalChild  + " Child Tickets\n" +
                           "          " + TotalSenior + " Senior Tickets\n" +
                           "Cost $" + totalTicketCost);
                addTicket = Show.KeyInfoInt();
            }

        }

        private static void TicketTally(int addTicket)
        {
            NumOfTickets++;

            if (addTicket == 1)
            {
                TotalAdult++;
                if (matinee)
                    totalTicketCost += Prices.MATINEE_ADULT;
                else
                    totalTicketCost += Prices.EVENING_ADULT;
            }
            else if (addTicket == 2)
            {
                TotalChild++;
                if (matinee)
                    totalTicketCost += Prices.MATINEE_CHILD;
                else
                    totalTicketCost += Prices.EVENING_CHILD;
            }
            else if (addTicket == 3)
            {
                TotalSenior++;
                if (matinee)
                    totalTicketCost += Prices.MATINEE_SENIOR;
                else
                    totalTicketCost += Prices.EVENING_SENIOR;
                    totalTicketCost += Prices.EVENING_SENIOR;
            }
        }
    }
}
