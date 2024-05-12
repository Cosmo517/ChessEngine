using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic.Pieces
{
    public class Rook : Piece
    {
        public override PieceType piece { get; } = PieceType.Rook;
        public override PieceColor Color { get; }
        public override bool HasMoved { get; set; } = false;

        public Rook(PieceColor color)
        {
            Color = color;
        }
    }
}
