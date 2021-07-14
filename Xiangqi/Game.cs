using System.Windows.Forms;
using System.Drawing;

namespace Xiangqi
{
     class Game
     {
          Panel[,] panels = new Panel[Ct.H, Ct.W];
        public Game(Form g)
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
                    panels[i, j].Top = i * Ct.Dim;
                    panels[i, j].Left = j * Ct.Dim;
                    panels[i, j].BackColor = curentColor;
                    panels[i, j].Height = Ct.Dim;
                    panels[i, j].Width = Ct.Dim;
                    
                    g.Controls.Add(panels[i, j]);
                }
            }
        }

        
     }
}