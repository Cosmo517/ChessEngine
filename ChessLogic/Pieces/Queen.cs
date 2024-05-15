namespace ChessLogic.Pieces
{
    public class Queen : Piece
    {
        public override PieceType piece { get; } = PieceType.Queen;
        public override PieceColor Color { get; }
        public override bool HasMoved { get; set; } = false;
        public override bool isSlidingPiece { get; } = true;


        public Queen(PieceColor color)
        {
            Color = color;
        }
    }
}
