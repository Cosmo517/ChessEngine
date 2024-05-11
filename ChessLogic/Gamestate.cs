namespace ChessLogic
{
    public class Gamestate
    {
        public Board Board { get; set; }
        public Gamestate(Board board)
        {
            Board = board;
        }
    }
}
