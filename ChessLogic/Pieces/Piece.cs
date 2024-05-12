using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic.Pieces
{
    public abstract class Piece
    {
        public abstract PieceType piece { get; }
        public abstract string Color { get; }
        public abstract bool HasMoved { get; set; }
    }
}
