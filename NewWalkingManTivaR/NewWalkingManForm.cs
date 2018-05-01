using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
/*
 * Created by: Tiva Rait
 * Created on: 01-05-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #32 - New Walking Man
 * This program let's you click four boxes and has walking man move.
*/

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

            // Declare local variables and constants
            const byte MAX_FRAMES = 10;
            int pictureFrameCounter = 1;

            // Continue this frame loop while the frame counter has not reached the max number of frames we have to display
            while (pictureFrameCounter < MAX_FRAMES + 1)
            {
                if (pictureFrameCounter == 1)
                {
                    tmpPicMan.Image = Properties.Resources.walk1;
                }
                else if (pictureFrameCounter == 2)
                {
                    tmpPicMan.Image = Properties.Resources.walk2;
                }
                else if (pictureFrameCounter == 3)
                {
                    tmpPicMan.Image = Properties.Resources.walk3;
                }
                else if (pictureFrameCounter == 4)
                {
                    tmpPicMan.Image = Properties.Resources.walk4;
                }
                else if (pictureFrameCounter == 5)
                {
                    tmpPicMan.Image = Properties.Resources.walk5;
                }
                else if (pictureFrameCounter == 6)
                {
                    tmpPicMan.Image = Properties.Resources.walk6;
                }
                else if (pictureFrameCounter == 7)
                {
                    tmpPicMan.Image = Properties.Resources.walk7;
                }
                else if (pictureFrameCounter == 8)
                {
                    tmpPicMan.Image = Properties.Resources.walk8;
                }
                else if (pictureFrameCounter == 9)
                {
                    tmpPicMan.Image = Properties.Resources.walk9;
                }
                else
                {
                    tmpPicMan.Image = Properties.Resources.walk10;
                }
                // To increment counter
                pictureFrameCounter++;
                // To add the delay so it won't be too quick
                this.Refresh();
                Thread.Sleep(100);
            }
        
        }
    }
}
