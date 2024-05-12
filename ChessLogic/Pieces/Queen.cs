using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic.Pieces
{
    public class Queen : Piece
    {
        public override PieceType piece => PieceType.Queen;
        public override string Color { get; }
        public override bool HasMoved { get; set; } = false;

        public Queen(string color)
        {
            Color = color;
        }
    }
}
