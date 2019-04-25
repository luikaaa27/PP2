using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car
{
    public partial class Form1 : Form
    {
        List<Point> car = new List<Point>();
        int dx = 1;
        public Form1()
        {
            InitializeComponent();
            car.Add(new Point(36, 93));
            car.Add(new Point(81, 93));
            car.Add(new Point(94, 46));
            car.Add(new Point(182, 46));
            car.Add(new Point(220, 93));
            car.Add(new Point(69, 139));
            car.Add(new Point(190, 139));
            car.Add(new Point(75, 145));
            car.Add(new Point(195, 145));
            car.Add(new Point(141, 110));
            car.Add(new Point(141, 140));
            car.Add(new Point(148, 115));
            car.Add(new Point(148, 135));
            car.Add(new Point(89, 93));
            car.Add(new Point(99, 56));
            car.Add(new Point(141, 56));
            car.Add(new Point(141, 93));
            car.Add(new Point(148, 93));
            car.Add(new Point(148, 56));
            car.Add(new Point(179, 56));
            car.Add(new Point(207, 93));
            timer1.Start();
        }
        
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen black = new Pen(Color.Black);
            e.Graphics.DrawRectangle(black, car[0].X, car[0].Y, 230, 55);

            Point p = new Point(car[1].X, car[1].Y);
            Point w = new Point(car[2].X, car[2].Y);
            Point f = new Point(car[3].X, car[3].Y);
            Point r = new Point(car[4].X, car[4].Y);
            Point[] points = { p, w, f, r };
            e.Graphics.DrawPolygon(black, points);

            e.Graphics.DrawEllipse(black, car[5].X, car[5].Y, 50, 50);
            e.Graphics.DrawEllipse(black, car[6].X, car[6].Y, 50, 50);
            e.Graphics.DrawEllipse(black, car[7].X, car[7].Y, 39, 39);
            e.Graphics.DrawEllipse(black, car[8].X, car[8].Y, 39, 39);

            e.Graphics.DrawLine(black, car[9].X, car[9].Y, car[10].X, car[10].Y);
            e.Graphics.DrawLine(black, car[11].X, car[11].Y, car[12].X, car[12].Y);

            Point g = new Point(car[13].X, car[13].Y);
            Point j = new Point(car[14].X, car[14].Y);
            Point k = new Point(car[15].X, car[15].Y);
            Point l = new Point(car[16].X, car[16].Y);
            Point[] points1 = { g, j, k, l };
            e.Graphics.DrawPolygon(black, points1);

            Point t = new Point(car[17].X, car[17].Y);
            Point u = new Point(car[18].X, car[18].Y);
            Point y = new Point(car[19].X, car[19].Y);
            Point o = new Point(car[20].X, car[20].Y);
            Point[] points2 = { t, u, y, o };
            e.Graphics.DrawPolygon(black, points2);

            for (int i = 0; i < 21; i++)
            {
                car[i] = new Point(car[i].X + dx, car[i].Y);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dx += 1;
            Refresh();
        }
    }
}
