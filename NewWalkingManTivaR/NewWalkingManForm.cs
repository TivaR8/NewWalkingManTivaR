using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewWalkingManTivaR
{
    public partial class frmNewWalkingMan : Form
    {
        public frmNewWalkingMan()
        {
            InitializeComponent();
        }

        private void GeneratePictureBoxes()
        {
            // Generate each of the picture boxes on the form
            GeneratePictureBox(61, 78);
            GeneratePictureBox(464, 78);
            GeneratePictureBox(61, 358);
            GeneratePictureBox(464, 358);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Reveal the instructions
            this.lblInstructions.Show();

            // Generate the picture boxes with their event listeners
            GeneratePictureBoxes();
        }

        private void GeneratePictureBox(int x, int y)
        {
            // Dynamically generate a new picture box and a new point at the given location (x, y)
            PictureBox tmpPicMan = new PictureBox();
            Point pntPic = new System.Drawing.Point(x, y);

            // Set location of the picture box
            tmpPicMan.Location = pntPic;

            // Assign the image to the picture box
            tmpPicMan.Image = Properties.Resources.walk1;

            // Strech the image to the size of the picture box
            tmpPicMan.SizeMode = PictureBoxSizeMode.StretchImage;

            // Make the picture box width and height to be the same as the image
            tmpPicMan.ClientSize = new Size(Properties.Resources.walk1.Width, Properties.Resources.walk1.Height);

            // Add the event listener
            tmpPicMan.Click += new System.EventHandler(PictureBox_Click);

            // Add the picture box to the form
            this.Controls.Add(tmpPicMan);

        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            // Cast the sender object into a picture Box
            PictureBox tmpPicMan = (PictureBox)sender;

            // Write a message to the console to check which picture box was clicked
            Console.WriteLine("Picture box (" + tmpPicMan.Location.X + ", " + tmpPicMan.Location.Y + ") was clicked.");
            
        }
    }
}
