using System;
using System.Drawing;
using System.Windows.Forms;

namespace Flipper
{
    public partial class OutputForm : Form
    {
        private readonly Timer timer;
        private readonly SourceForm captureForm;

        public OutputForm()
        {
            InitializeComponent();
            TopMost = alwaysOnTopToolStripMenuItem.Checked = true;

            captureForm = new SourceForm(this);
            captureForm.Show(this);

            timer = new Timer();
            timer.Tick += timer_Tick;
            UpdateSpeed(Speed.Medium);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Image screenShot = captureForm.CaptureScreenShot();

            RotateFlipType flipType = RotateFlipType.RotateNoneFlipNone;

            if (invertToolStripMenuItem.Checked)
            {
                flipType = RotateFlipType.Rotate180FlipX;
            }
            else if (rotate90DegToolStripMenuItem.Checked)
            {
                flipType = RotateFlipType.Rotate90FlipNone;
            }
            else if (rotate180DegToolStripMenuItem.Checked)
            {
                flipType = RotateFlipType.Rotate180FlipNone;
            }
            else if (rotate270DegToolStripMenuItem.Checked)
            {
                flipType = RotateFlipType.Rotate270FlipNone;
            }

            flippedPictureBox.Image = ProcessImage(screenShot, flipType);
        }

        private void copyToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(flippedPictureBox.Image);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();
            captureForm.Close();
            Close();
        }

        private void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopMost = alwaysOnTopToolStripMenuItem.Checked;
        }

        private void slowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateSpeed(Speed.Slow);
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateSpeed(Speed.Medium);
        }

        private void fastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateSpeed(Speed.Fast);
        }

        private void invertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetFlipTypeMenuStates(invert : true);
        }

        private void rotate90DegToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetFlipTypeMenuStates(rotate90 : true);
        }

        private void rotate180DegToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetFlipTypeMenuStates(rotate180 : true);
        }

        private void rotate270DegToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetFlipTypeMenuStates(rotate270 : true);
        }

        private void SetFlipTypeMenuStates(bool invert = false, bool rotate90 = false, bool rotate180 = false, bool rotate270 = false)
        {
            invertToolStripMenuItem.Checked = invert;
            rotate90DegToolStripMenuItem.Checked = rotate90;
            rotate180DegToolStripMenuItem.Checked = rotate180;
            rotate270DegToolStripMenuItem.Checked = rotate270;
        }

        private static Image ProcessImage(Image image, RotateFlipType rotateFlipType)
        {
	        Image flipped = (Image) image.Clone();
            flipped.RotateFlip(rotateFlipType);
            return flipped;
        }

        private void UpdateSpeed(Speed speed)
        {
            timer.Stop();
            timer.Interval = (int) speed;
            timer.Start();

            slowToolStripMenuItem.Checked = (speed == Speed.Slow);
            mediumToolStripMenuItem.Checked = (speed == Speed.Medium);
            fastToolStripMenuItem.Checked = (speed == Speed.Fast);
        }

        private enum Speed
        {
            Slow = 1000,
            Medium = 500,
            Fast = 100
        }
    }
}
