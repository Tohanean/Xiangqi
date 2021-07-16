using System;
using System.Drawing;
using System.Windows.Forms;

namespace Xiangqi
{
   
        class Board
        {
            Panel[,] panels = new Panel[Ct.H, Ct.W];
            public Board(Form b)
            {

                panels = new Panel[Ct.H + 1, Ct.W + 1];
                for (int i = 1; i <= Ct.H ; i++)
                {
                    for (int j = 1; j <= Ct.W; j++)
                    {
                        Color curentColor;
                        if ((i + j) % 2 == 0)
                            curentColor = Color.Brown;
                        else
                            curentColor = Color.Khaki;



                        panels[i, j] = new Panel();

                        //panels[i, j].colo 

                        //ControlPaint.DrawBorder(panels[i,j].Graphics, this.panels.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
                        //if (i == 5)
                       // {
                            panels[i, j].BorderStyle = BorderStyle.Fixed3D;
                    // }

                     panels[i, j].BackColor = Color.Transparent;
                    //panels[i, j].Height = Ct.Dim;
                    //panels[i, j].Width = Ct.Dim;
                  
                    //this.panels[i, j].BackColor;

                    this.panels[i, j].Left = (Ct.LeftBoardPosition + 20) + j  * (Ct.CellSize + Ct.CellPadding);
                        this.panels[i, j].Top = (Ct.TopBoardPosition + 20) + i  * (Ct.CellSize + Ct.CellPadding);
                        this.panels[i, j].Size = new System.Drawing.Size(Ct.CellSize, Ct.CellSize);

                        this.panels[i, j].MouseEnter += OnMouseEnter;
                        this.panels[i, j].MouseLeave += OnMouseLeave;



                        b.Controls.Add(panels[i, j]);
                    }
                }

               
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
