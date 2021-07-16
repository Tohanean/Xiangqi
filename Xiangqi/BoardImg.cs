using System.Drawing;
using System.Windows.Forms;


namespace Xiangqi
{
    class BoardImg
    {
        
        PictureBox pb;
        public BoardImg(Form pic)
        {
            pb = new PictureBox();
            //pb.Image= Image.FromHbitmap(Xiangqi.Properties.Resources.smboard);

        }
    }
}



/*
Image img;
PictureBox pb;
int xPos, yPos;
string[] filenames; // array of filenames from the folder 
for (int i = 0; i < filenames.Length; i++)
{
    img = Image.FromFile(filenames[0]);
    // calculate xPos and yPos here using img width & height and spacing you require 
    // between two images (horizontally and vertically) 
    //pb = new PictureBox();
    pb.Image = img;
    pb.Size = img.Size;
    pb.Location = new Point(xPos, yPos);
    this.Controls.Add(pb);
}
*/