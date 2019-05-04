namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Board chessBoard = new Board(8, 8);
            chessBoard.PrintBoard();

            while (true)
            {
                chessBoard.MovePiece();
                chessBoard.PrintBoard();
            }
        }
    }
}
