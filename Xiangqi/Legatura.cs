using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xiangqi
{
    class Legatura
    {
        public Board board = new Board(Ct.H, Ct.W);
        public List<Piece> pieces = new List<Piece>();

        internal void ShowPieces(PictureBox p)
        {
            foreach (Piece piece in pieces)
            {
                piece.Show(p);
            }
        }
    }
}
