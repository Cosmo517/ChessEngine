using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic.Pieces
{
    public class Piece
    {
        public virtual PieceType piece { get; } = PieceType.None;
        public virtual PieceColor Color { get; } = PieceColor.None;
        public virtual bool HasMoved { get; set; } = false;
    }
}
