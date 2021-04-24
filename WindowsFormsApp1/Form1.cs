using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
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
                var paper = panel2.CreateGraphics();
                var pen = new Pen(Color.Blue, 2);
                if (frm.textBox1 != null && frm.textBox2 != null && frm.textBox3 != null)
                { 
                    paper.DrawEllipse(pen, Convert.ToInt32(frm.textBox1.Text), Convert.ToInt32(frm.textBox2.Text),
                                      Convert.ToInt32(frm.textBox3.Text), Convert.ToInt32(frm.textBox3.Text));
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 FLine = new Form3();
            if (FLine.ShowDialog(this) == DialogResult.OK)
            {
                var paper = panel2.CreateGraphics();
                if (FLine.textBox1 != null && FLine.textBox2 != null && FLine.textBox3 != null && FLine.textBox4 != null)
                {
                    
                    paper.DrawLine(new Pen(Color.Green, 2), Convert.ToInt32(FLine.textBox1.Text), Convert.ToInt32(FLine.textBox2.Text),
                                                            Convert.ToInt32(FLine.textBox3.Text), Convert.ToInt32(FLine.textBox4.Text));
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 FTrian = new Form4();
            if (FTrian.ShowDialog(this) == DialogResult.OK)
            {
                var paper = panel2.CreateGraphics();
                if (FTrian.textBox1 != null && FTrian.textBox2 != null && FTrian.textBox3 != null && FTrian.textBox4 != null)
                {
                    Pen blackPen = new Pen(Color.Black, 3);
                    int x1 = Convert.ToInt32(FTrian.textBox1.Text) + (Convert.ToInt32(FTrian.textBox4.Text) / 2);
                    int y1 = Convert.ToInt32(FTrian.textBox2.Text) + (Convert.ToInt32(FTrian.textBox4.Text) / 2);
                    int x2 = Convert.ToInt32(FTrian.textBox1.Text) - (Convert.ToInt32(FTrian.textBox4.Text) / 2);
                    int y2 = Convert.ToInt32(FTrian.textBox2.Text) - (Convert.ToInt32(FTrian.textBox4.Text) / 2);
                    int x3 = Convert.ToInt32(FTrian.textBox1.Text) + Convert.ToInt32(FTrian.textBox3.Text);
                    int y3 = Convert.ToInt32(FTrian.textBox2.Text) + Convert.ToInt32(FTrian.textBox3.Text);
                    Point point1 = new Point(x1, y1);
                    Point point2 = new Point(x2, y2);
                    Point point3 = new Point(x3, y3);
                    Point[] curvePoints = {point1, point2, point3};
                    paper.DrawPolygon(blackPen, curvePoints);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 FRect = new Form5();
            if (FRect.ShowDialog(this) == DialogResult.OK)
            {
                var paper = panel2.CreateGraphics();
                if (FRect.textBox1 != null && FRect.textBox2 != null && FRect.textBox3 != null && FRect.textBox4 != null) 
                { 
                    paper.DrawRectangle(new Pen(Color.Green, 2), Convert.ToInt32(FRect.textBox1.Text), Convert.ToInt32(FRect.textBox2.Text),
                                                                 Convert.ToInt32(FRect.textBox3.Text), Convert.ToInt32(FRect.textBox4.Text));
                }
            }
        }
    }
}
