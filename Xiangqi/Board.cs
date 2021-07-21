using System;
using System.Drawing;
using System.Windows.Forms;

namespace Xiangqi
{

    class Board
    {
        public Square[,] squares;
        public int rowCount = Ct.H;
        public int columnCount = Ct.W;

        public Board(int boardRowCount, int boardColumnCount)
        {
            squares = new Square[boardRowCount + 1, boardColumnCount + 1];
            this.rowCount = boardRowCount;
            this.columnCount = boardColumnCount;
            for (int i = 1; i <= rowCount; i++)
            {
                for (int j = 1; j <= columnCount; j++)
                {
                    squares[i, j] = new Square {color = Color.OrangeRed, piece= null};
                    // if ((i + j) % 2 == 0)
                    // squares[i, j] = new Square {color = Color.LightCoral, piece = null};
                    //  else
                    //  squares[i, j] = new Square {color = Color.Black, piece = null};

                }
            }
        }

        public void Show(Graphics g)
        {
            int dim = 50;
            for (int i = 1; i <= rowCount; i++)
            {
                for (int j = 1; j <= columnCount; j++)
                {
                    g.FillRectangle(new SolidBrush(squares[i, j].color), Ct.LeftBoardPosition + j * (Ct.CellSize + Ct.CellPadding), Ct.TopBoardPosition + i * (Ct.CellSize + Ct.CellPadding), Ct.CellSize, Ct.CellSize);
                }
            }
        }
    }
}
