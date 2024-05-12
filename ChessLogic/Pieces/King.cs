using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic.Pieces
{
    public class King : Piece
    {
        public override PieceType piece => PieceType.King;
        public override string Color { get; }
        public override bool HasMoved { get; set; } = false;

        public King(string color)
        {
            Color = color;
        }
    }
}
