using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayNight
{
    public partial class Form1 : Form
    {
        List<Point> moon = new List<Point>();
        List<Point> sun = new List<Point>();
        int dx = 1;
        public Form1()
        {
            InitializeComponent();
            moon.Add(new Point(45,45));
            moon.Add(new Point(55, 43));
            sun.Add(new Point(50, 50));
            sun.Add(new Point(49, 49));
            sun.Add(new Point(25, 25));
            sun.Add(new Point(80, 110));
            sun.Add(new Point(85, 145));
            sun.Add(new Point(50, 94));
            sun.Add(new Point(30, 120));
            sun.Add(new Point(40, 70));
            sun.Add(new Point(9, 70));
            sun.Add(new Point(110, 90));
            sun.Add(new Point(140, 110));
            sun.Add(new Point(72, 40));
            sun.Add(new Point(70, 10));
            sun.Add(new Point(100, 54));
            sun.Add(new Point(130, 35));
            timer1.Start();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen blue = new Pen(Color.DarkBlue);
            Pen green = new Pen(Color.Green);
            Pen yellow = new Pen(Color.Yellow);
            Pen orange = new Pen(Color.OrangeRed);
            Pen red = new Pen(Color.Red);
            Pen golden = new Pen(Color.LightGoldenrodYellow);

            e.Graphics.FillRectangle(blue.Brush, 0, 0, 600, 210);
            e.Graphics.FillRectangle(green.Brush, 0, 210, 600, 400);
            e.Graphics.FillEllipse(yellow.Brush,moon[0].X, moon[0].Y, 50, 50);
            e.Graphics.FillEllipse(blue.Brush, moon[1].X, moon[1].Y, 50, 50);
  
            Point star1 = new Point(445, 25);
            Point star2 = new Point(440, 35);
            Point star3 = new Point(430, 40);
            Point star4 = new Point(440, 45);
            Point star5 = new Point(445, 55);
            Point star6 = new Point(450, 45);
            Point star7 = new Point(460, 40);
            Point star8 = new Point(450, 35);

            Point[] Star = { star1, star2, star3, star4, star5, star6, star7, star8 };
            e.Graphics.FillPolygon(golden.Brush, Star);

            Point star9 = new Point(245, 25);
            Point star10 = new Point(240, 35);
            Point star11 = new Point(230, 40);
            Point star12 = new Point(240, 45);
            Point star13 = new Point(245, 55);
            Point star14 = new Point(250, 45);
            Point star15 = new Point(260, 40);
            Point star16 = new Point(250, 35);

            Point[] Star2 = { star9, star10, star11, star12, star13, star14, star15, star16 };
            e.Graphics.FillPolygon(golden.Brush, Star2);

            Point star17 = new Point(145, 65);
            Point star18 = new Point(140, 75);
            Point star19 = new Point(130, 80);
            Point star20 = new Point(140, 85);
            Point star21 = new Point(145, 95);
            Point star22 = new Point(150, 85);
            Point star23 = new Point(160, 80);
            Point star24 = new Point(150, 75);

            Point[] Star3 = { star17, star18, star19, star20, star21, star22, star23, star24 };
            e.Graphics.FillPolygon(golden.Brush, Star3);

            Point star25 = new Point(345, 65);
            Point star26 = new Point(340, 75);
            Point star27 = new Point(330, 80);
            Point star28 = new Point(340, 85);
            Point star29 = new Point(345, 95);
            Point star30 = new Point(350, 85);
            Point star31 = new Point(360, 80);
            Point star32 = new Point(350, 75);
          
            Point[] Star4 = { star25, star26, star27, star28, star29, star30, star31, star32 };
            e.Graphics.FillPolygon(golden.Brush, Star4);
            for(int i = 0; i < 2; i++)
            {
                moon[i] = new Point(moon[i].X + dx, moon[i].Y);
                if (moon[i].X >= this.Width)
                {
                    e.Graphics.FillRectangle(orange.Brush, 0, 0, 600, 210);
                    e.Graphics.FillRectangle(green.Brush, 0, 210, 600, 400);
                    e.Graphics.FillEllipse(yellow.Brush, sun[0].X, sun[0].Y, 50, 50);
                    e.Graphics.DrawLine(yellow, sun[1].X, sun[1].Y, sun[2].X, sun[2].Y);
                    e.Graphics.DrawLine(yellow, sun[3].X, sun[3].Y, sun[4].X, sun[4].Y);
                    e.Graphics.DrawLine(yellow, sun[5].X, sun[5].Y, sun[6].X, sun[6].Y);
                    e.Graphics.DrawLine(yellow, sun[7].X, sun[7].Y, sun[8].X, sun[8].Y);
                    e.Graphics.DrawLine(yellow, sun[9].X, sun[9].Y, sun[10].X, sun[10].Y);
                    e.Graphics.DrawLine(yellow, sun[11].X, sun[11].Y, sun[12].X, sun[12].Y);
                    e.Graphics.DrawLine(yellow, sun[13].X, sun[13].Y, sun[14].X, sun[14].Y);
                    for (int j = 0; j < 15; j++)
                    {
                        sun[j] = new Point(sun[j].X + dx, sun[j].Y);
                    }
                }
                
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
