using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueRed
{
    public partial class Form1 : Form
    {
        List<Point> car = new List<Point>();
        SolidBrush blue = new SolidBrush(Color.Blue);
        
        int dx = 0;
        int dy = 0;
        public Form1()
        {
            InitializeComponent();
            car.Add(new Point(30, 80));
            car.Add(new Point(50,40));

            timer1.Start();
        }

        private void Up_Click(object sender, EventArgs e)
        {
            dy-=20;
            if (car[0].Y + dy - 40 <0)
            {
                blue = new SolidBrush(Color.Red);
            }
            else
            {
                blue = new SolidBrush(Color.Blue);
            }

        }

        private void Down_Click(object sender, EventArgs e)
        {
            dy += 20;
            if (car[0].Y + dy + 100 >= pictureBox1.Height )
            {
                blue = new SolidBrush(Color.Red);
            }
            else
            {
                blue = new SolidBrush(Color.Blue);
            }

        }

        private void Left_Click(object sender, EventArgs e)
        {
            dx -= 20;
            if(car[0].X + dx < 0)
            {
                blue = new SolidBrush(Color.Red);
            }
            else
            {
                blue = new SolidBrush(Color.Blue);
            }

        }

        private void Right_Click(object sender, EventArgs e)
        {
            dx += 20;
            if (car[0].X + dx + 150 >=this.Width )
            {
                blue = new SolidBrush(Color.Red);
            }
            else
            {
                blue = new SolidBrush(Color.Blue);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
            e.Graphics.FillRectangle(blue, car[0].X+dx, car[0].Y+dy, 120, 90);
            e.Graphics.FillRectangle(new SolidBrush(Color.Black), car[1].X + dx, car[1].Y+dy, 80, 40);

        }
    }
}
