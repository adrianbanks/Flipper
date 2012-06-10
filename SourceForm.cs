using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Flipper
{
    public partial class SourceForm : Form
    {
        private readonly OutputForm owner;

        public SourceForm(OutputForm owner)
        {
            InitializeComponent();
            
            this.owner = owner;
            Size = owner.Size;
            Location = new Point(owner.Location.X + Size.Width, owner.Location.Y);
            this.owner.Resize += owner_Resize;
            this.Opacity = 0.35;
        }

        private void owner_Resize(object sender, EventArgs e)
        {
            Size = owner.Size;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            
            using (Graphics g = this.CreateGraphics())
            {
                g.FillRectangle(new SolidBrush(this.BackColor), this.Bounds);
            }

            DrawBorder();
        }

        private void DrawBorder()
        {
            using (Pen pen = new Pen(Color.Red, 2))
            {
                using (Graphics g = this.CreateGraphics())
                {
                    g.DrawLine(pen, 1, 1, Width - 1, 1);
                    g.DrawLine(pen, Width - 1, 1, Width - 1, Height - 1);
                    g.DrawLine(pen, Width - 1, Height - 1, 1, Height - 1);
                    g.DrawLine(pen, 1, Height - 1, 0, 0);
                }
            }
        }

        public Image CaptureScreenShot()
        {
            Size size = new Size(Width - 2, Height - 2);

            using (Bitmap bmp = new Bitmap(size.Width, size.Height, PixelFormat.Format32bppArgb))
            {
                using (Graphics gfx = Graphics.FromImage(bmp))
                {
                    gfx.CopyFromScreen(Location.X + 1, Location.Y + 1, 0, 0, size, CopyPixelOperation.SourceCopy);

                    using (MemoryStream ms = new MemoryStream())
                    {
                        bmp.Save(ms, ImageFormat.Jpeg);
                        return (Bitmap) bmp.Clone();
                    }
                }
            }
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x84;
            const int HTCLIENT = 0x1;
            const int HTCAPTION = 0x2;

            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
            
                    if ((int) m.Result == HTCLIENT)
                    {
                        m.Result = (IntPtr) HTCAPTION;
                    }
                    
                    return;
            }

            base.WndProc(ref m);
        }
    }
}