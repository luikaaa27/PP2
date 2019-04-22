using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleFallsDown
{
    public partial class Form1 : Form
    {
        SolidBrush brush = new SolidBrush(Color.Blue);
        int dy = 1;
        int r = 10;
        List<Point> cPoint = new List<Point>();
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            for(int i = 0; i < cPoint.Count(); i++)
            {
                e.Graphics.FillEllipse(brush, new Rectangle(cPoint[i].X - r, cPoint[i].Y - r, 2 * r, 2 * r));
                cPoint[i] = new Point(cPoint[i].X,cPoint[i].Y+dy);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            cPoint.Add(e.Location);
        }
    }
}
