using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic.Pieces
{
    public abstract class Piece
    {
        public PieceType piece { get; } = PieceType.None;
        public abstract PieceColor Color { get; }
        public abstract bool HasMoved { get; set; }
    }
}
