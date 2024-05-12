namespace ChessLogic
{
    public class Gamestate
    {
        public Board Board { get; set; }
        public PieceColor CurrentPlayer {  get; private set; }
        public Gamestate(Board board)
        {
            Board = board;
            CurrentPlayer = PieceColor.White;
        }
    }
}
