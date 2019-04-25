using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficLights
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval += 100;
        }
        int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter < 10)
            {
                pictureBox1.ImageLocation = @"C:\Users\asus-\Desktop\green.png";
            }
            else if (counter < 13)
            {
                pictureBox1.ImageLocation = @"C:\Users\asus-\Desktop\yellow.png";
            }
            else if (counter < 20)
            {
                pictureBox1.ImageLocation = @"C:\Users\asus-\Desktop\red.png";
            }

            if (counter == 20)
            {
                counter = 0;
            }
        }
    }
}
