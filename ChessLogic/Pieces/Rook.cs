namespace ChessLogic.Pieces
{
    public class Rook : Piece
    {
        public override PieceType piece { get; } = PieceType.Rook;
        public override PieceColor Color { get; }
        public override bool HasMoved { get; set; } = false;
        public override bool isSlidingPiece { get; } = true;


        public Rook(PieceColor color)
        {
            Color = color;
        }
    }
}
