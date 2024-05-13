using ChessLogic.Pieces;
using System.Diagnostics;

namespace ChessLogic
{
    public class Board
    {
        // Index 0-5 is Black, Index 6-11 is White
        // Order is Pawn, Bishop, Knight, Rook, Queen, King
        public ulong[] bitboards = { 0b0, 0b0, 0b0, 0b0, 0b0, 0b0,
                                     0b0, 0b0, 0b0, 0b0, 0b0, 0b0, };

        public Piece[] boardHelper = new Piece[64];

        public List<Move> moves = new List<Move>();

        // The initializing of the board
        public static Board Initial(string FEN)
        {
            Board board = new Board();
            board.AddStartPieces(FEN);
            return board;
        }

        // This function acts as a helper function to generate
        // bitboards. Basically FEN -> 1D Array -> Piece Bitboards
        private void generateBoard(string FEN)
        {
            // Initialize each spot with a new piece
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    boardHelper[i * 8 + j] = new Piece();

            string positions = FEN.Split(' ')[0];
            // Grab just the algebraic notation
            string[] sections = positions.Split('/');

            // Loop through each section, and then through each string
            // this will create the pieces within the board
            for (int i = 0; i < sections.Length; i++)
            {
                int column = 0;
                for (int j = 0; j < sections[i].Length; j++)
                {
                    // Empty spaces
                    if (sections[i][j] > '0' && sections[i][j] < '9')
                    {
                        column += sections[i][j] - '0';
                        continue;
                    }
                    // create the 2d board to then generate bitboards properly
                    switch (sections[i][j])
                    {
                        case 'p':
                            boardHelper[i * 8 + column] = new Pawn(PieceColor.Black);
                            break;
                        case 'r':
                            boardHelper[i * 8 + column] = new Rook(PieceColor.Black);
                            break;
                        case 'n':
                            boardHelper[i * 8 + column] = new Knight(PieceColor.Black);
                            break;
                        case 'b':
                            boardHelper[i * 8 + column] = new Bishop(PieceColor.Black);
                            break;
                        case 'q':
                            boardHelper[i * 8 + column] = new Queen(PieceColor.Black);
                            break;
                        case 'k':
                            boardHelper[i * 8 + column] = new King(PieceColor.Black);
                            break;

                        case 'P':
                            boardHelper[i * 8 + column] = new Pawn(PieceColor.White);
                            break;
                        case 'R':
                            boardHelper[i * 8 + column] = new Rook(PieceColor.White);
                            break;
                        case 'N':
                            boardHelper[i * 8 + column] = new Knight(PieceColor.White);
                            break;
                        case 'B':
                            boardHelper[i * 8 + column] = new Bishop(PieceColor.White);
                            break;
                        case 'Q':
                            boardHelper[i * 8 + column] = new Queen(PieceColor.White);
                            break;
                        case 'K':
                            boardHelper[i * 8 + column] = new King(PieceColor.White);
                            break;

                    }
                    column++;
                }
            }
        }

        private void AddStartPieces(string FEN)
        {
            // Generate the board so we can construct the bitboards
            generateBoard(FEN);
            
            // Loop through the board
            for (int i = 63; i >= 0; i--)
            {
                Piece currentPiece = boardHelper[63 - i];
                PieceType currentPieceType = currentPiece.piece;
                PieceColor currentPieceColor = currentPiece.Color;
                if (currentPieceType != PieceType.None)
                {
                    int pieceBitboard = (int)currentPieceType + (int)currentPieceColor;
                    bitboards[pieceBitboard] |= 1ul << i;
                }
            }

            // how to print out to debug the binary bits
            //Debug.WriteLine(Convert.ToString((long)bitboards[0], 2).PadLeft(64, '0'));
        }

        public List<Move> GenerateMoves()
        {

            return moves;
        }
    }
}
