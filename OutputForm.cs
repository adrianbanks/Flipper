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
            flippedPictureBox.Image = Flip(screenShot);
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
         
        private static Image Flip(Image image)
        {
	        Image flipped = (Image) image.Clone();
            flipped.RotateFlip(RotateFlipType.Rotate180FlipX);
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
