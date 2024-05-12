using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic.Pieces
{
    public class Rook : Piece
    {
        public override PieceType piece => PieceType.Rook;
        public override string Color { get; }
        public override bool HasMoved { get; set; } = false;

        public Rook(string color)
        {
            Color = color;
        }
    }
}
