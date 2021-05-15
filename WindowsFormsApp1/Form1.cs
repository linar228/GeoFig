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
        int x, y, h, w;
        Image file;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          switch(textBox1.Text)
          {
                case "Circle" : Form2 FCirc = new Form2();
                                FCirc.Show();
                                break;
                case "Line": Form3 FLine = new Form3();
                             FLine.Show();
                             break;
                case "Triangle": Form4 FTrian = new Form4();
                                 FTrian.Show();
                                 break;
                case "Rectangle": Form5 FRect = new Form5();
                                  FRect.Show();
                                  break;
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                var paper = Board.CreateGraphics();
                var pen = new Pen(Color.Blue, 2);
                if (frm.X != null && frm.Y != null && frm.Radius != null)
                { 
                    paper.DrawEllipse(pen, Convert.ToInt32(frm.X.Text), Convert.ToInt32(frm.Y.Text),
                                      Convert.ToInt32(frm.Radius.Text), Convert.ToInt32(frm.Radius.Text));
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 FLine = new Form3();
            if (FLine.ShowDialog(this) == DialogResult.OK)
            {
                var paper = Board.CreateGraphics();
                if (FLine.X1 != null && FLine.Y1 != null && FLine.Y2 != null && FLine.X2 != null)
                {
                    
                    paper.DrawLine(new Pen(Color.Green, 2), Convert.ToInt32(FLine.X1.Text), Convert.ToInt32(FLine.Y1.Text),
                                                            Convert.ToInt32(FLine.Y2.Text), Convert.ToInt32(FLine.X2.Text));
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 FTrian = new Form4();
            if (FTrian.ShowDialog(this) == DialogResult.OK)
            {
                var paper = Board.CreateGraphics();
                if (FTrian.X1 != null && FTrian.Y1 != null && FTrian.X2 != null && FTrian.Y2 != null && FTrian.X3 != null && FTrian.Y3 != null)
                {
                    Pen blackPen = new Pen(Color.Black, 3);
                    int x1 = Convert.ToInt32(FTrian.X1.Text);
                    int y1 = Convert.ToInt32(FTrian.Y1.Text);
                    int x2 = Convert.ToInt32(FTrian.X2.Text);
                    int y2 = Convert.ToInt32(FTrian.Y2.Text);
                    int x3 = Convert.ToInt32(FTrian.Y3.Text);
                    int y3 = Convert.ToInt32(FTrian.X3.Text);

                    paper.DrawLine(blackPen, x1, y1, x2, y2);
                    paper.DrawLine(blackPen, x2, y2, x3, y3);
                    paper.DrawLine(blackPen, x1, y1, x3, y3);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
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

        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG(*.JPG)|*.jpg";
            if(f.ShowDialog()==DialogResult.OK)
            {
                file = Image.FromFile(f.FileName);
              //  pictureBox1.Image = file;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            h = e.X - x;
            w = e.Y - y;
            Graphics g = Board.CreateGraphics();
            Rectangle shape = new Rectangle(x, y, h, w);
            if(radioButton1.Checked)
            {
                g.DrawEllipse(new Pen(Color.Green, 2), shape);
            }
            else if(radioButton2.Checked)
            {
                g.DrawRectangle(new Pen(Color.Green, 2), shape);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Graphics g = Board.CreateGraphics();
            g.Clear(Color.White);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 FRect = new Form5();
            if (FRect.ShowDialog(this) == DialogResult.OK)
            {
                var paper = Board.CreateGraphics();
                if (FRect.X != null && FRect.Y != null && FRect.Width != null && FRect.Length != null) 
                { 
                    paper.DrawRectangle(new Pen(Color.Green, 2), Convert.ToInt32(FRect.X.Text), Convert.ToInt32(FRect.Y.Text),
                                                                 Convert.ToInt32(FRect.Width.Text), Convert.ToInt32(FRect.Length.Text));
                }
            }
        }

        private void radioButton1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void radioButton1_MouseUp(object sender, MouseEventArgs e)
        {
            var p = new Pen(Color.Blue, 2);
            h = e.X - x;
            w = e.Y - y;
            Graphics g = Board.CreateGraphics();
            Rectangle shape = new Rectangle(x, y, h, w);
            if(radioButton1.Checked)
            {
                g.DrawEllipse(p, shape);
            }
            else if(radioButton2.Checked)
            {
                g.DrawRectangle(p, shape);
            }
        }
    }
}
