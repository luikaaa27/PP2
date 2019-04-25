using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveOnCircle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
        double a=0;
        double x, y = 20, l = 0, r = 0;

      

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x = x + 10* Math.Cos(Math.PI*a/180.0);
            y = y + 10* Math.Sin(Math.PI*a/180.0);
            a +=10;
            Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(new Pen(Color.Black), 110,80,110,110);
            e.Graphics.FillEllipse(new SolidBrush(Color.Maroon), (int)x+150, (int)y+50, 20, 20);
            e.Graphics.FillEllipse(new SolidBrush(Color.Yellow), 140, 113, 50, 50);
            e.Graphics.DrawEllipse(new Pen(Color.YellowGreen), 140, 112, 50, 50);
        }
        
    }
}
