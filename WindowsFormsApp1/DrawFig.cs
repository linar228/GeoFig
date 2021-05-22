using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    public class Figure
    {
        protected int x;
        protected int y;

        public Figure(int x, int y)
        {
        
        }

        public virtual void Draw(Graphics graphics, Pen pen, Rectangle rectangle)
        {

        }
    }

    class Circle : Figure
    {
        public Circle(int x, int y, Graphics graphics, Pen pen, Rectangle rectangle) : base(x, y)
        {
            
        }

        public override void Draw(Graphics g, Pen p, Rectangle shape)
        {
            g.DrawEllipse(p, shape);
        }
    }

    class Line : Figure
    {
        public Line(int x, int y, int x1, int y1) : base(x, y)
        {

        }

        public void Draw()
        {

        }
    }

    class Triangle : Figure
    {
        public Triangle(int x, int y, int baseT, int height) : base(x, y)
        {

        }

        public void Draw()
        {

        }
    }

    class RectangleC : Figure
    {
        public RectangleC(int x, int y, Graphics graphics, Pen pen, Rectangle rectangle) : base(x, y)
        {

        }
        public override void Draw(Graphics g, Pen p, Rectangle shape)
        {
            g.DrawRectangle(p, shape);
        }
    }
}
