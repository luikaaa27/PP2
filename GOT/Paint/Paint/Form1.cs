using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    enum PaintToolState
    {
        Line,
        Rectangle,
        Pencil,
        Ellipse,
        Fill,
        Eraser,
        Fill2
    }
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Graphics graphics;
        Pen pen = new Pen(Color.Red);
        Pen eraserPen = new Pen(Color.White, 3);

        PaintToolState toolstate = PaintToolState.Pencil;
        Point prevPoint;
        Point curPoint;

        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            pictureBox1.Image = bitmap;

            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            eraserPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            eraserPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void LineBtn_Click(object sender, EventArgs e)
        {
            toolstate = PaintToolState.Line;
        }

        private void RectangelBtn_Click(object sender, EventArgs e)
        {
            toolstate = PaintToolState.Rectangle;
        }

        private void PencilBtn_Click(object sender, EventArgs e)
        {
            toolstate = PaintToolState.Pencil;
        }

        private void EllipseBtn_Click(object sender, EventArgs e)
        {
            toolstate = PaintToolState.Ellipse;
        }

        private void FillBtn_Click(object sender, EventArgs e)
        {
            toolstate = PaintToolState.Fill;
        }

        private void EraserBtn_Click(object sender, EventArgs e)
        {
            toolstate = PaintToolState.Eraser;
        }

        private void Fill2Btn_Click(object sender, EventArgs e)
        {
            toolstate = PaintToolState.Fill2;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                curPoint = e.Location;

                switch (toolstate)
                {
                    case PaintToolState.Pencil:
                        graphics.DrawLine(pen, prevPoint, curPoint);
                        prevPoint = curPoint;
                        break;
                    case PaintToolState.Eraser:
                        graphics.DrawLine(eraserPen, prevPoint, curPoint);
                        prevPoint = curPoint;
                        break;
                    default:
                        break;
                }
                pictureBox1.Refresh();
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            prevPoint = e.Location;
            if (toolstate == PaintToolState.Fill)
            {
                DummyFill dummyFill = new DummyFill();
                dummyFill.Fill(bitmap, pen.Color, e.Location);
                pictureBox1.Refresh();
            }
            else if (toolstate == PaintToolState.Fill2)
            {
                MapFill mapFill = new MapFill();
                mapFill.Fill(graphics, e.Location, pen.Color, ref bitmap);
                graphics = Graphics.FromImage(bitmap);
                pictureBox1.Image = bitmap;
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            switch (toolstate)
            {
                case PaintToolState.Line:
                    e.Graphics.DrawLine(pen, prevPoint, curPoint);
                    break;
                case PaintToolState.Rectangle:
                    e.Graphics.DrawRectangle(pen, GetRectangle(prevPoint, curPoint));
                    break;
                case PaintToolState.Pencil:
                    break;
                case PaintToolState.Ellipse:
                    e.Graphics.DrawEllipse(pen, GetRectangle(prevPoint, curPoint));
                    break;
                case PaintToolState.Fill:
                    break;
                default:
                    break;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            switch (toolstate)
            {
                case PaintToolState.Line:
                    graphics.DrawLine(pen, prevPoint, curPoint);
                    break;
                case PaintToolState.Rectangle:
                    graphics.DrawRectangle(pen, GetRectangle(prevPoint, curPoint));
                    break;
                case PaintToolState.Pencil:
                    break;
                case PaintToolState.Ellipse:
                    graphics.DrawEllipse(pen, GetRectangle(prevPoint, curPoint));
                    break;
                case PaintToolState.Fill:
                    break;
                default:
                    break;
            }
        }
        Rectangle GetRectangle(Point p1, Point p2)
        {
            return new Rectangle
            {
                X = Math.Min(p1.X, p2.X),
                Y = Math.Min(p1.Y, p2.Y),
                Height = Math.Abs(p1.Y - p2.Y),
                Width = Math.Abs(p1.X - p2.X)
            };
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (toolstate == PaintToolState.Pencil)
            {
                pen.Width = int.Parse(numericUpDown1.Value.ToString());
            }
            else
            {
                eraserPen.Width = int.Parse(numericUpDown1.Value.ToString());
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bitmap.Save(saveFileDialog1.FileName);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bitmap = Bitmap.FromFile(openFileDialog1.FileName) as Bitmap;
                graphics = Graphics.FromImage(bitmap);
                pictureBox1.Image = bitmap;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog1.Color;
            }
        }

        private void colorToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
