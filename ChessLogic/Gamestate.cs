namespace ChessLogic
{
    public class Gamestate
    {
        public Board Board { get; set; }
        public PieceColor CurrentPlayer {  get; private set; }
        public Gamestate(PieceColor startingPlayer, Board board)
        {
            Board = board;
            CurrentPlayer = startingPlayer;
        }
    }
}
