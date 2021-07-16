using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xiangqi
{
    public partial class GameScreen : Form
    {
       

        Game game; 
        Board board;
        public GameScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            //game.Show();
        }

        private void startGame_Click(object sender, EventArgs e)
        {
              game = new Game(this);
           // board = new Board(b:this);
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
