using System.Windows.Forms;
using System.Drawing;
using System;

namespace Xiangqi
{
     class GameBoard
     {
          Panel[,] panels = new Panel[Ct.H, Ct.W];
        public GameBoard(Form g)
        {
            
            panels = new Panel[Ct.H + 1, Ct.W + 1];
            for (int i = 1; i <= Ct.H; i++)
            {
                for (int j = 1; j <= Ct.W; j++)
                {
                    Color curentColor;
                    if ((i + j) % 2 == 0)
                        curentColor = Color.Aquamarine;
                    else
                        curentColor = Color.DodgerBlue;

                   

                    panels[i, j] = new Panel();
                    //this.panels[i, j].BackgroundImage = Xiangqi.Properties.Resources.we_b_general;
                    //panels[i, j].colo 

                    //ControlPaint.DrawBorder(panels[i,j].Graphics, this.panels.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
                    // if (i == 5 )
                    // {
                    panels[i, j].BorderStyle = BorderStyle.Fixed3D;
                    // }

                    // panels[i, j].BackColor = curentColor;
                    //panels[i, j].Height = Ct.Dim;
                    //panels[i, j].Width = Ct.Dim;
                    if ( (i<=3) && ((j>3) && (j<=6)) )
                    {
                        panels[i, j].BackColor = Color.Brown;
                    }

                    if ((i > 7) && ((j > 3) && (j <= 6)))
                    {
                        panels[i, j].BackColor = Color.SlateGray;
                    }

                    if ((i == 1) && (j == 5))
                    {
                        panels[i, j].BackgroundImage = Xiangqi.Properties.Resources.we_b_general;

                    }



                    this.panels[i, j].Left = Ct.LeftBoardPosition + j * (Ct.CellSize + Ct.CellPadding);
                    this.panels[i, j].Top = Ct.TopBoardPosition + i * (Ct.CellSize + Ct.CellPadding);
                    this.panels[i, j].Size = new System.Drawing.Size(Ct.CellSize, Ct.CellSize);
                   
                   // this.panels[i, j].MouseEnter += OnMouseEnter;
                   // this.panels[i, j].MouseLeave += OnMouseLeave;
                    this.panels[i, j].MouseDoubleClick += OnMouseDoubleClick;



                    g.Controls.Add(panels[i, j]);
                }
            }
        }

        private void OnMouseDoubleClick(object sender, MouseEventArgs e)
        {
           ((Panel)sender).BackgroundImage = Xiangqi.Properties.Resources.we_b_general;

        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = Color.GreenYellow;
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = Color.DodgerBlue;
        }

       
    }
}