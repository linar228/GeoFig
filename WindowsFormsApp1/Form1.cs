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
        protected Graphics g;
        public Form1()
        {
            InitializeComponent();
            draw = new Bitmap(1920, 1080);
            g = Graphics.FromImage(draw);
            g.Clear(Color.White);
        }
        int x, y, h, w;
        Image file;
        Point v1;
        Point v2;
        Point v3;
        bool getv1 = false;
        bool getv2 = false;
        bool getv3 = false;

      
        private void button6_Click(object sender, EventArgs e)
        {
            /*
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Рисунок .bmp | *.bmp";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                int width, height;
                width = Board.Width;
                height = Board.Height;
                Bitmap bmp = new Bitmap(width, height);
                Board.DrawToBitmap(bmp, Board.ClientRectangle);
                bmp.Save(sfd.FileName);
            }
            */
            draw.Save("D:\\test.png", System.Drawing.Imaging.ImageFormat.Png);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //OpenFileDialog f = new OpenFileDialog();
            //f.Filter = "JPG(*.JPG)|*.jpg";
            //if(f.ShowDialog()==DialogResult.OK)
            //{
            //file = Image.FromFile(f.FileName);
            //  pictureBox1.Image = file;
            //}

            var img = new Bitmap("D:\\test.png");
            draw.Dispose();
            draw = new Bitmap(img);
            g = Graphics.FromImage(draw);
            Board.Refresh();
            img.Dispose();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            var g = Graphics.FromImage(draw);
            g.Clear(Color.White);
            Board.Refresh();
        }

        private void Board_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            Pen blackPen = new Pen(Color.Black, 3);
            if (getv1)
            {
                v1 = new Point(e.X, e.Y);
                Board.Refresh();
            }
            if (getv2)
            {
                v2 = new Point(e.X, e.Y);
                g.DrawLine(blackPen, v1, v2);
                Board.Refresh();
            }
            if (getv3)
            {
                v3 = new Point(e.X, e.Y);
                g.DrawLine(blackPen, v3, v2);
                g.DrawLine(blackPen, v3, v1);
                Board.Refresh();
            }

            Board.Cursor = Cursors.Default;
            getv1 = false;
            getv2 = false;
            getv3 = false;
        }

        private void Board_MouseUp(object sender, MouseEventArgs e)
        {
            var p = new Pen(Color.Blue, 2);
            h = e.X - x;
            w = e.Y - y;
            Rectangle shape = new Rectangle(x, y, h, w);
            if (radioButton1.Checked)
            {
                Figure circle = new Circle(x, y, g, p, shape);
                circle.Draw(g, p, shape);
                Board.Refresh();
            }
            else if (radioButton2.Checked)
            {
                Figure rectangle = new RectangleC(x, y, g, p, shape);
                rectangle.Draw(g, p, shape);
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

        private void Board_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(draw, new Point(0, 0));
        }

        private void radioButton1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }
    }
}
