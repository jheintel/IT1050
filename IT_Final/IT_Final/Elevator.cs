namespace IT_Final
{
    class Elevator
    {
        private double MaxWeight;
        private Passenger[] Occupants;

        public Elevator(int maxOccupents, double maxWeight)
        {
            Occupants = new Passenger[maxOccupents];
            MaxWeight = maxWeight;
        }

        public void AddOccupant(Passenger passenger, int index)
        {
            Occupants[index] = passenger;
        }

        public double GetCurrentWeight()
        {
            double sum = 0;
            for (int i = 0; i < Occupants.Length; i++)
            {
                sum += Occupants[i].GetWeight();
            }
            return sum;
        }

        public bool IsOverMaxCapacity()
        {
            return MaxWeight < GetCurrentWeight();
        }
    }
}
