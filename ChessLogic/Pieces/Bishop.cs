using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic.Pieces
{
    public class Bishop : Piece
    {
        public override PieceType piece { get; } = PieceType.Bishop;
        public override PieceColor Color { get; }
        public override bool HasMoved { get; set; } = false;

        public Bishop(PieceColor color)
        {
            Color = color;
        }
    }
}
