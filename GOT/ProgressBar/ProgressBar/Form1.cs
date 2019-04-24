using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBar
{
    public partial class Form1 : Form
    {
        float dx = 1.0F;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dx += 3.5F;
            Refresh();
            this.progressBar1.Increment(1);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen red = new Pen(Color.Red);
            e.Graphics.FillPie(red.Brush, new Rectangle(40, 40, 40, 40), 0, dx);
        }
    }
}
