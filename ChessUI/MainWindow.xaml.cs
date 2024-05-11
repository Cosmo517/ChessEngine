using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
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
        private Cell[,] cells = new Cell[8, 8];

        public MainWindow()
        {
            InitializeComponent();
            InitializeBackground();
        }

        private void InitializeBackground()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j =  0; j < 8; j++)
                {
                    Image image = new Image();
                    Rectangle rect = new Rectangle();
                    Pieces.Children.Add(image);
                    CellsBackground.Children.Add(rect);
                    cells[i, j] = new Cell(rect, image);

                    if (i % 2 == 0) 
                    {
                        if (j % 2 == 0)
                        {
                            cells[i, j].getPiece().Source = new BitmapImage(new Uri("Pieces/B_King.png", UriKind.Relative));
                            cells[i, j].getSpace().Fill = new SolidColorBrush(Colors.White);
                        }
                        else
                        {
                            cells[i, j].getPiece().Source = new BitmapImage(new Uri("Pieces/B_King.png", UriKind.Relative));
                            cells[i, j].getSpace().Fill = new SolidColorBrush(Colors.SandyBrown);
                        }
                    }
                    else
                    {
                        if (j % 2 != 0)
                        {
                            cells[i, j].getPiece().Source = new BitmapImage(new Uri("Pieces/B_King.png", UriKind.Relative));
                            cells[i, j].getSpace().Fill = new SolidColorBrush(Colors.White);
                        }
                        else
                        {
                            cells[i, j].getPiece().Source = new BitmapImage(new Uri("Pieces/B_King.png", UriKind.Relative));
                            cells[i, j].getSpace().Fill = new SolidColorBrush(Colors.SandyBrown);
                        }
                    }
                }
            }
        }
    }
}