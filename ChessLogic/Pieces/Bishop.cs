using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic.Pieces
{
    public class Bishop : Piece
    {
        public override PieceType piece => PieceType.Bishop;
        public override string Color { get; }
        public override bool HasMoved { get; set; } = false;

        public Bishop(string color)
        {
            Color = color;
        }
    }
}
