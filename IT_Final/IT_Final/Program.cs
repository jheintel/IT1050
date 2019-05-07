namespace IT_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator1 = new Elevator(2, 400);
            Passenger A1 = new Passenger("A1", 180);
            Passenger A2 = new Passenger("A2", 220);
            elevator1.AddOccupant(A1, 0);
            elevator1.AddOccupant(A2, 1);
            bool elevator1IsOverMaxCapacity = elevator1.IsOverMaxCapacity();

            Elevator elevator2 = new Elevator(3, 600);
            Passenger A21 = new Passenger("A1", 200);
            Passenger A22 = new Passenger("A2", 200);
            Passenger A23 = new Passenger("A3", 201);
            elevator2.AddOccupant(A21, 0);
            elevator2.AddOccupant(A22, 1);
            elevator2.AddOccupant(A23, 2);
            bool elevator2IsOverMaxCapacity = elevator2.IsOverMaxCapacity();
        }
    }
}