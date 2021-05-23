using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Bitmap draw;
        protected Graphics graphics;
        protected int thickness;
        protected Color FigColor = Color.Black;
        int x, y, height, width;
        Point v1;
        Point v2;
        Point v3;
        bool getv1 = false;
        bool getv2 = false;
        bool getv3 = false;
        public Form1()
        {
            InitializeComponent();
            draw = new Bitmap(1920, 1080);
            graphics = Graphics.FromImage(draw);
            graphics.Clear(Color.White);
        }
      
        private void SaveBut_Click(object sender, EventArgs e)
        {
            draw.Save("D:\\Image.png", System.Drawing.Imaging.ImageFormat.Png);
        }

        private void OpenBut_Click(object sender, EventArgs e)
        {
            var img = new Bitmap("D:\\Image.png");
            draw.Dispose();
            draw = new Bitmap(img);
            graphics = Graphics.FromImage(draw);
            Board.Refresh();
            img.Dispose();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            var graphics = Graphics.FromImage(draw);
            graphics.Clear(Color.White);
            Board.Refresh();
        }

        private void Board_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            Pen blackPen = new Pen(FigColor, thickness);
            if (getv1)
            {
                v1 = new Point(e.X, e.Y);
                Board.Refresh();
            }
            if (getv2)
            {
                v2 = new Point(e.X, e.Y);
                graphics.DrawLine(blackPen, v1, v2);
                Board.Refresh();
            }
            if (getv3)
            {
                v3 = new Point(e.X, e.Y);
                graphics.DrawLine(blackPen, v3, v2);
                graphics.DrawLine(blackPen, v3, v1);
                Board.Refresh();
            }

            Board.Cursor = Cursors.Default;
            getv1 = false;
            getv2 = false;
            getv3 = false;
        }

        private void Board_MouseUp(object sender, MouseEventArgs e)
        {
            var pen = new Pen(FigColor, thickness);
            height = e.X - x;
            width = e.Y - y;
            Rectangle shape = new Rectangle(x, y, height, width);
            if (Circle.Checked)
            {
                Figure circle = new Circle(x, y, graphics, pen, shape);
                circle.Draw(graphics, pen, shape);
                Board.Refresh();
            }
            else if (Rectangle.Checked)
            {
                Figure rectangle = new RectangleC(x, y, graphics, pen, shape);
                rectangle.Draw(graphics, pen, shape);
                Board.Refresh();
            }
        }

        private void Point1_Click(object sender, EventArgs e)
        {
            getv1 = true;
            Board.Cursor = Cursors.Cross;
        }

        private void Point2_Click(object sender, EventArgs e)
        {
            getv2 = true;
            Board.Cursor = Cursors.Cross;
        }

        private void Point3_Click(object sender, EventArgs e)
        {
            getv3 = true;
            Board.Cursor = Cursors.Cross;
        }

        private void thicknessBar_Scroll(object sender, EventArgs e)
        {
            thickness = thicknessBar.Value;
        }

        private void Color_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog(this) == DialogResult.OK)
            {
                ColorBut.BackColor = colorDialog.Color;
                FigColor = colorDialog.Color;
            }
        }

        private void Board_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(draw, new Point(0, 0));
        }

        private void Circle_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }
    }
}
