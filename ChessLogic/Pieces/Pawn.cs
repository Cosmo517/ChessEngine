using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic.Pieces
{
    public class Pawn : Piece
    {
        public override PieceType piece => PieceType.Pawn;
        public override string Color { get; }
        public override bool HasMoved { get; set; } = false;

        public Pawn(string color)
        {
            Color = color;
        }
    }
}
