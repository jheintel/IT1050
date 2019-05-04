using IO = System.Console;

namespace Lab5
{
    class Board
    {
        private int gridX;
        private int gridY;

        private string[][] grid;

        public Board(int x, int y)
        {
            gridX = x;
            gridY = y;

            grid = new string[gridX][];

            for (int i = 0; i < gridX; i++)
            {
                grid[i] = new string[gridY];
                for(int j = 0; j<gridY; j++)
                {
                    if(j==0 || j==1  || (j==gridY-2) || (j==gridY-1))
                    {
                        grid[i][j] = "x";
                    }

                }
            }
        }

        public void MovePiece()
        {
            int oldX = 0;
            int oldY = 0;
            int newX = 0;
            int newY = 0;

            IO.WriteLine("Note: exit program by entering out of bounds coordinate");
            IO.Write("Enter Target X Coordinate Between 0 and 7 :");
            oldX = AssignCoordinate(int.Parse(IO.ReadLine()), gridX);
            IO.Write("Enter Target Y Coordinate Between 0 and 7 :");
            oldY = AssignCoordinate(int.Parse(IO.ReadLine()), gridY);
            IO.Write("Enter Destination X Coordinate Between 0 and 7 :");
            newX = AssignCoordinate(int.Parse(IO.ReadLine()), gridX);
            IO.Write("Enter Destination Y Coordinate Between 0 and 7 :");
            newY = AssignCoordinate(int.Parse(IO.ReadLine()), gridY);

            this.grid[newX][newY] = this.grid[oldX][oldY];
            this.grid[oldX][oldY] = " ";
        }

        public void PrintBoard()
        {
            IO.Clear();
            IO.Write("  ");
            for (int i = 0; i < gridX; i++)
                IO.Write("  " + (i) + " ");

            IO.WriteLine();

            for (int i = 0; i < gridY; i++)
            {
                Divider();
                IO.Write((i) + " ");
                for (int j = 0; j < gridX; j++)
                    if (grid[j][i] == "x")
                    {
                        IO.Write("| x " );
                    }
                    else
                    {
                        IO.Write("|   ");
                    }
                    IO.WriteLine("|");
            }
            Divider();
            IO.WriteLine();
        }

        private int AssignCoordinate(int coordinate, int bound)
        {
            if(coordinate > (bound-1) || coordinate < 0)
            {
                System.Environment.Exit(1);
            }

            return coordinate;
        }

        private void Divider()
        {
            IO.Write("  ");
            for (int i=gridX; i>0; i--)
                IO.Write("+---");
            IO.WriteLine("+");
        }
    }
}
