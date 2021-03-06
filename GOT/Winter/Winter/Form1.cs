﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winter
{
    public partial class Form1 : Form
    {
        int r = 5;
        Random rd = new Random();
        List<Point> cPoint = new List<Point>();
        int dy = 1;
        SolidBrush brush = new SolidBrush(Color.White);
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            for (int i = 0; i < cPoint.Count(); ++i)
            {
                cPoint[i] = new Point(cPoint[i].X, cPoint[i].Y + dy);
                e.Graphics.FillEllipse(brush, new Rectangle(cPoint[i].X - r, cPoint[i].Y - r, 2 * r, 2 * r));
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 776; i += 5)
            {
                int x = rd.Next(1, 1000);
                if (x < 10)
                {
                    cPoint.Add(new Point(i, 0));
                }
            }
            Refresh();
        }
    }
}
