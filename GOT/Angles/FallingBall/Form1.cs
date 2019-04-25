using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FallingBall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
        double a = 0;
        float x = -1, y = -1, l = -1, r = -1, d = 0;
        bool finish = true;
        List<Point> sled = new List<Point>();
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            finish = false;
            a = 0;
            d = (l - x) * (l - x) + (r - y) * (r - y);
            d = (float)Math.Sqrt(Convert.ToDouble(d));
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            l = e.X;
            r = e.Y;
            finish = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (!finish)
            {
                //e.Graphics.DrawEllipse(new Pen(Color.Black), 110,80,110,110);
                e.Graphics.DrawArc(new Pen(Color.Maroon), l, r - d / 2, d, d, 180, 360);
                e.Graphics.DrawArc(new Pen(Color.White), l, r - d / 2, d, d, 0, 180);
                //e.Graphics.FillEllipse(new SolidBrush(Color.Yellow), 140, 113, 50, 50);
                // e.Graphics.DrawEllipse(new Pen(Color.YellowGreen), 140, 112, 50, 50);
            }
        }

    }
}
