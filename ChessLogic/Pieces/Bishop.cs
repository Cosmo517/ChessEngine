namespace ChessLogic.Pieces
{
    public class Bishop : Piece
    {
        public override PieceType piece { get; } = PieceType.Bishop;
        public override PieceColor Color { get; }
        public override bool HasMoved { get; set; } = false;
        public override bool isSlidingPiece { get; } = true;

        public Bishop(PieceColor color)
        {
            Color = color;
        }
    }
}
