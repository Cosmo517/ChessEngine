using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic.Pieces
{
    public class Pawn : Piece
    {
        public override PieceType piece { get; } = PieceType.Pawn;
        public override PieceColor Color { get; }
        public override bool HasMoved { get; set; } = false;

        public Pawn(PieceColor color)
        {
            Color = color;
        }
    }
}
