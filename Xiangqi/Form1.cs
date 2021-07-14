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
        public GameScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(this);
            //game.Show();
        }

        private void startGame_Click(object sender, EventArgs e)
        {
           

        }
    }
}
