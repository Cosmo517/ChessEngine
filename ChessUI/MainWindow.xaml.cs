using ChessLogic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ChessUI
{
    class Cell
    {
        Rectangle space;
        Image piece = null;
        public Cell(Rectangle space, Image piece)
        {
            this.space = space;
            this.piece = piece;
        }

        public Rectangle getSpace() { return space; }

        public void setSpace(Rectangle space) { this.space = space; }

        public Image getPiece() { return piece; }

        public void setPiece(Image piece) {  this.piece = piece; }

    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Cell[] cells = new Cell[64];

        public MainWindow()
        {
            InitializeComponent();
            InitializeBoard();

            string startingFEN = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR";

            Gamestate game = new Gamestate(PieceColor.White, Board.Initial(startingFEN));

            // Draw the starting position of the baord with a FEN string
            DrawBoard(startingFEN);
        }

        private void InitializeBoard()
        {
            // Loop through the array of cells
            for (int i = 0; i < 64; i++)
            {
                // Create a new image and rectangle, and append them
                // to the proper UniformGrid
                Image image = new Image();
                Rectangle rect = new Rectangle();
                Pieces.Children.Add(image);
                CellsBackground.Children.Add(rect);
                cells[i] = new Cell(rect, image);
                // Display the background cells properly.
                if (i / 8 % 2 == 0)
                {
                    if ((i + 1) % 2 == 0)
                        cells[i].getSpace().Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3a6ee8"));
                    else
                        cells[i].getSpace().Fill = new SolidColorBrush(Colors.White);
                }
                else
                {
                    if ((i + 1) % 2 == 0)
                        cells[i].getSpace().Fill = new SolidColorBrush(Colors.White);
                    else
                        cells[i].getSpace().Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3a6ee8"));
                }
            }
        }

        private void DrawBoard(string FEN)
        {
            // Split the FEN string incase its the full string
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
                        column += sections[i][j]  - '0';
                        continue;
                    }
                    // Create the images of the piece
                    switch (sections[i][j])
                    {
                        case 'p':
                            cells[i * 8 + column].getPiece().Source = new BitmapImage(new Uri("Pieces/B_Pawn.png", UriKind.Relative));
                            break;
                        case 'r':
                            cells[i * 8 + column].getPiece().Source = new BitmapImage(new Uri("Pieces/B_Rook.png", UriKind.Relative));
                            break;
                        case 'n':
                            cells[i * 8 + column].getPiece().Source = new BitmapImage(new Uri("Pieces/B_Knight.png", UriKind.Relative));
                            break;
                        case 'b':
                            cells[i * 8 + column].getPiece().Source = new BitmapImage(new Uri("Pieces/B_Bishop.png", UriKind.Relative));
                            break;
                        case 'q':
                            cells[i * 8 + column].getPiece().Source = new BitmapImage(new Uri("Pieces/B_Queen.png", UriKind.Relative));
                            break;
                        case 'k':
                            cells[i * 8 + column].getPiece().Source = new BitmapImage(new Uri("Pieces/B_King.png", UriKind.Relative));
                            break;

                        case 'P':
                            cells[i * 8 + column].getPiece().Source = new BitmapImage(new Uri("Pieces/W_Pawn.png", UriKind.Relative));
                            break;
                        case 'R':
                            cells[i * 8 + column].getPiece().Source = new BitmapImage(new Uri("Pieces/W_Rook.png", UriKind.Relative));
                            break;
                        case 'N':
                            cells[i * 8 + column].getPiece().Source = new BitmapImage(new Uri("Pieces/W_Knight.png", UriKind.Relative));
                            break;
                        case 'B':
                            cells[i * 8 + column].getPiece().Source = new BitmapImage(new Uri("Pieces/W_Bishop.png", UriKind.Relative));
                            break;
                        case 'Q':
                            cells[i * 8 + column].getPiece().Source = new BitmapImage(new Uri("Pieces/W_Queen.png", UriKind.Relative));
                            break;
                        case 'K':
                            cells[i * 8 + column].getPiece().Source = new BitmapImage(new Uri("Pieces/W_King.png", UriKind.Relative));
                            break;

                    }
                    column++;
                }
            }
        }
    }
}