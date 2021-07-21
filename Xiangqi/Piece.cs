using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Xiangqi
{
    public class Piece
    {
        public string name;

        public (int x, int y) position;

        public int player; // cine detine piesa
        public Color color = new Color();

        public int value;
        public List<(int, int)> validMoves = new List<(int, int)>();
        //public PictureBox poza;
        public string imageURL;

        public Piece(string name, Color color, int player, (int, int) position, int value, string imageURL)
        {
            this.name = name;
            this.color = color;
            this.player = player;
            this.position = position;
            this.value = value;
            //this.poza = new PictureBox();
            //poza.Load(imageURL);
            this.imageURL = imageURL;
        }

        //   public PictureBox Poza { get => poza; set => poza = value; }

        public void Show(PictureBox p)
        {
            PictureBox poza = new PictureBox();
            poza.Load(imageURL);
            //poza.Image =Image.FromFile(@"C:\Users\tohan\Pictures\we_r_soldier.png");
            //poza.BackgroundImage = Xiangqi.Properties.Resources.we_b_general;
            poza.Height = 70;
            poza.Width = 70;
            poza.Top = 31 * (20 - position.x * 2);
            poza.Left = 34 * (20 - (position.y * 2));
            poza.BackColor = Color.Black;
            poza.SizeMode = PictureBoxSizeMode.Zoom;


            p.Controls.Add(poza);
            poza.BringToFront();
            p.Refresh();
        }
    }
}
