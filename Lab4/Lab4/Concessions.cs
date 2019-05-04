namespace Lab4
{
    class Concessions
    {
        private static int TotalSmallSoda = 0;
        private static int TotalLargeSoda = 0;
        private static int TotalHotDog = 0;
        private static int TotalPopcorn = 0;
        private static int TotalCandy = 0;

        private static int FreeCandy = 0;
        private static int FreePopcorn = 0;
        private static int numOfDiscounts = 0;

        public static double TotalConcessionsCost
        {
            get { return totalConcessionsCost; }
            set { totalConcessionsCost = value; }
        }
        private static double totalConcessionsCost = 0;

        public static void WhatToEat()
        {
            int addFoodItem = 0;
            const int DONE_ORDERING = 6;
            numOfDiscounts = Tickets.NumOfTickets;


            while (addFoodItem != DONE_ORDERING)
            {
                Show.Clear();

                if(FreePopcorn < 1)
                    PopcornPromotion();

                Show.WriteLine("What would you like to eat?");
                Show.WriteLine("Enter a corrisponding number to add a snack");
                Show.WriteLine("1. Small Soda $" + Prices.SMALL_SODA);
                Show.WriteLine("2. Large Soda $" + Prices.LARGE_SODA);
                Show.WriteLine("3. Hot Dog $" + Prices.HOT_DOG);
                Show.WriteLine("4. Popcorn $" + Prices.POPCORN);
                Show.WriteLine("5. Candy $" + Prices.CANDY);
                Show.WriteLine("6. Done");

                if (addFoodItem == 1)
                {
                    TotalSmallSoda++;
                    totalConcessionsCost += Prices.SMALL_SODA;
                }
                else if (addFoodItem == 2)
                {
                    TotalLargeSoda++;
                    totalConcessionsCost += Prices.LARGE_SODA;
                }
                else if (addFoodItem == 3)
                {
                    TotalHotDog++;
                    totalConcessionsCost += Prices.HOT_DOG;
                }
                else if (addFoodItem == 4)
                {
                    TotalPopcorn++;
                    totalConcessionsCost += Prices.POPCORN;
                }
                else if (addFoodItem == 5)
                {
                    TotalCandy++;
                    totalConcessionsCost += Prices.CANDY;
                }

                Show.WriteLine();
                Show.WriteLine("Small Sodas " + TotalSmallSoda);
                Show.WriteLine("Large Sodas " + TotalLargeSoda);
                Show.WriteLine("Hot Dogs " + TotalHotDog);
                Show.WriteLine("Popcorn " + (TotalPopcorn + FreePopcorn));
                if (TotalCandy != 0 && TotalCandy % 3 == 0)
                    CandyPromotion();
                Show.WriteLine("Candy " + (TotalCandy + FreeCandy));                

                Show.WriteLine();
                Show.WriteLine("Concessions $" + totalConcessionsCost);
                Show.WriteLine("Tickets $" + Tickets.TotalTicketCost);
                Show.WriteLine("Total $" + (totalConcessionsCost + Tickets.TotalTicketCost));
                addFoodItem = Show.KeyInfoInt();
            }

            CornAndSodaPromo(numOfDiscounts);
        }

        private static void CandyPromotion()
        {
            FreeCandy++;
            Show.WriteLine("You earned a free candy!");
        }

        private static void PopcornPromotion()
        {
            const int REQUIRED_TICKETS = 3;
            if (!Tickets.Matinee && (Tickets.NumOfTickets >= REQUIRED_TICKETS))
            {
                FreePopcorn++;
                Show.WriteLine("You earned a free popcorn!");
            }
        }

        private static void CornAndSodaPromo(int numOfDiscounts)
        {
            const double PROMO_DISCOUNT = 2;

            numOfDiscounts = System.Math.Min(numOfDiscounts, TotalPopcorn);
            numOfDiscounts = System.Math.Min(numOfDiscounts, TotalLargeSoda);
            Tickets.TotalTicketCost -= (numOfDiscounts * PROMO_DISCOUNT);
        }
    }
}
