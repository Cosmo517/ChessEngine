using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic.Pieces
{
    public class Knight : Piece
    {
        public override PieceType piece => PieceType.Knight;
        public override string Color { get; }
        public override bool HasMoved { get; set; } = false;

        public Knight(string color)
        {
            Color = color;
        }
    }
}
