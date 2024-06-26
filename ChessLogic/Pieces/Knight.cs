﻿namespace ChessLogic.Pieces
{
    public class Knight : Piece
    {
        public override PieceType piece { get; } = PieceType.Knight;
        public override PieceColor Color { get; }
        public override bool HasMoved { get; set; } = false;

        public Knight(PieceColor color)
        {
            Color = color;
        }
    }
}
