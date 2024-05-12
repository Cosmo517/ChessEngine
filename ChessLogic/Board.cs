using ChessLogic.Pieces;

namespace ChessLogic
{
    public class Board
    {
        public Piece[,] pieces = new Piece[8, 8];

        public Piece this[int row, int col]
        {
            get { return pieces[row, col]; }
            set { pieces[row, col] = value; }
        }

        // The initializing of the board
        public static Board Initialize()
        {
            Board board = new Board();
            board.AddStartPieces();
            return board;
        }

        private void AddStartPieces()
        {
            this[0, 0] = new Rook(PieceColor.Black);
            this[0, 1] = new Knight(PieceColor.Black);
            this[0, 2] = new Bishop(PieceColor.Black);
            this[0, 3] = new Queen(PieceColor.Black);
            this[0, 4] = new King(PieceColor.Black);
            this[0, 5] = new Bishop(PieceColor.Black);
            this[0, 6] = new Knight(PieceColor.Black);
            this[0, 7] = new Rook(PieceColor.Black);

            this[7, 0] = new Rook(PieceColor.White);
            this[7, 1] = new Knight(PieceColor.White);
            this[7, 2] = new Bishop(PieceColor.White);
            this[7, 3] = new Queen(PieceColor.White);
            this[7, 4] = new King(PieceColor.White);
            this[7, 5] = new Bishop(PieceColor.White);
            this[7, 6] = new Knight(PieceColor.White);
            this[7, 7] = new Rook(PieceColor.White);

            for (int i = 0; i < 8; i++)
            {
                this[1, i] = new Pawn(PieceColor.Black);
                this[6, i] = new Pawn(PieceColor.White);
            }
        }
    }
}
