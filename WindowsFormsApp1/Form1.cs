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
                var pen = new Pen(Color.Blue, 5);
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
                if (FLine.textBox1 != null && FLine.textBox2 != null)
                {
                    paper.DrawLine(new Pen(Color.Green, 6), Convert.ToInt32(FLine.textBox1.Text), Convert.ToInt32(FLine.textBox2.Text),
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
                paper.DrawLines(new Pen(Color.Green, 6), new Point(60, 30), new Point(150, 70), new Point(100, 70));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 FRect = new Form5();
            if (FRect.ShowDialog(this) == DialogResult.OK)
            {
                var paper = panel2.CreateGraphics();
                Pen blackPen = new Pen(Color.Black, 3);
                PointF point1 = new PointF(50.0F, 50.0F);
                PointF point2 = new PointF(100.0F, 25.0F);
                PointF point3 = new PointF(200.0F, 5.0F);
                PointF point4 = new PointF(250.0F, 50.0F);
                PointF[] curvePoints ={
                                       point1,
                                       point2,
                                       point3,
                                       point4,
                                      };
                paper.DrawLines(new Pen(Color.Green, 6), new Point(60, 30), new Point(150, 70), new Point(100, 70));
            }
        }
    }
}
