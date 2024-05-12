using ChessLogic.Pieces;
using System.Diagnostics;

namespace ChessLogic
{
    public class Board
    {
        // Index 0-5 is White, Index 6-11 is Black
        // Order is Pawn, Bishop, Knight, Rook, Queen, King
        public UInt64[] bitboards = { 0b0, 0b0, 0b0, 0b0, 0b0, 0b0, 
                                      0b0, 0b0, 0b0, 0b0, 0b0, 0b0, };

        public Piece[] boardHelper = new Piece[64];

        // The initializing of the board
        public static Board Initial(string FEN)
        {
            Board board = new Board();
            board.AddStartPieces(FEN);
            return board;
        }

        private void generateBoard(string FEN)
        {
            string positions = FEN.Split(' ')[0];
            // Grab just the algebraic notation
            string[] sections = positions.Split('/');

            // Loop through each section, and then through each string
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
            generateBoard(FEN);
            
            for (int i = 0; i < boardHelper.Length; i++)
            {
                Piece currentPiece = boardHelper[i];
                PieceType currentPieceType = currentPiece.piece;
                PieceColor currentPieceColor = currentPiece.Color;
                if (currentPieceType != PieceType.None)
                { 

                }
            }

            // how to print out to debug the binary bits
            // Debug.WriteLine(Convert.ToString((long)blackRookMask, 2));
        }
    }
}
