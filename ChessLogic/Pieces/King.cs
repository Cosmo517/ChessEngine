namespace ChessLogic.Pieces
{
    public class King : Piece
    {
        public override PieceType piece { get; } = PieceType.King;
        public override PieceColor Color { get; }
        public override bool HasMoved { get; set; } = false;

        public King(PieceColor color)
        {
            Color = color;
        }
    }
}
