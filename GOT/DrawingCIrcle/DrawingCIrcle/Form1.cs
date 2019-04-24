using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingCIrcle
{
    public partial class Form1 : Form
    {
    //List<Point> circle = new List<Point>();
            Pen blackPen = new Pen(Color.Black, 3);
            
            Rectangle rect = new Rectangle(0, 0, 100, 100);
           

        float startAngle = 0;
        float sweepAngle = 10;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawArc(blackPen, rect, startAngle, sweepAngle);
            for(int i = 0; i <= 15; i++)
            {
                sweepAngle += 1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
