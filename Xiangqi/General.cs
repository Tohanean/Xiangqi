using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Xiangqi
{
    class General : Piece
    {
        public General(string name, Color color, int player, (int, int) position, int value, string imageURL) : base(
            name, color, player, position, value, imageURL)
        {

        }
    }
}
