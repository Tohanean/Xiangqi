using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xiangqi.Properties;

namespace Xiangqi
{
    public partial class GameScreen : Form
    {
        Legatura legatura = new Legatura();
        GameBoard gameBoard; 
       // Board board;
        
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
              gameBoard = new GameBoard(this);
           // board = new Board(b:this);
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //legatura.ShowPieces(panel1);
           // board = new Board(this);
            //gameBoard = new GameBoard(this);
            legatura.board.Show(this.CreateGraphics());
            //legatura.ShowPieces(new TableLayoutPanel());
            BringToFront();
            for (int i = 1; i < 11; i++)
            {
                legatura.pieces.Add(
                    new General
                    (
                        "General",
                        Color.Red,
                        1,
                        (2, 4),
                        1,
                        @"C:\Users\tohan\Pictures\we_r_soldier.png"


                    )

                );
            }

            legatura.pieces.Add(
                new General(
                    "general",
                    Color.Black,
                    1,
                    (3, 5),
                    2,
                    @"C:\Users\tohan\Pictures\we_r_soldier.png"
                )
                );



        }
    }
}
