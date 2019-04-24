using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Angles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int dx = 5;
        int dy = 5;
        int x = 100, y = 100, r = 20;
        SolidBrush pen = new SolidBrush(Color.Red);

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.Location.X;
            y = e.Location.Y;
            timer1.Start();
        }
        Random rd = new Random();

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(pen, x - r, y - r, 2 * r, 2 * r);
            x += dx;
            y += dy;
            if (y + 2 * r >= this.Height || y <= 0)
            {
                dy = -dy;
            }
            if (y + 2 * r >= this.Height || y <= 0)
            {
                pen.Color = Color.FromArgb(rd.Next(20,256),rd.Next(0,256), rd.Next(0,255),255);
            }
            if (x + 2 * r >= this.Width || x <= 0)
                dx = -dx;
            if (x + 2 * r >= this.Width || x <= 0)
            {
                pen.Color = Color.FromArgb(rd.Next(0, 256), rd.Next(0, 256), 0);
            }
        }
        +
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
