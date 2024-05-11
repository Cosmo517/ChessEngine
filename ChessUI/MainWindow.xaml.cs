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
        string color;
        Image piece;
        public Cell(String color, Image piece)
        {
            this.color = color;
            this.piece = piece;
        }

        public string getColor() { return color; }

        public void setColor(String color) { this.color = color; }

        public Image getPiece() { return piece; }

        public void setPiece(Image piece) {  this.piece = piece; }

    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Cell[,] cells = new Cell[8, 8];

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

                }
            }
        }
    }
}