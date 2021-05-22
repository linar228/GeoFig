/*
Valiev Linar
Task: geometric shapes
17.03.2021
*/
using System;

class Program
{
    static void Main()
    {
        Circle circle = new Circle(1, 1, 4);
        circle.Draw();

        Line line = new Line(1, 1, 5, 6);
        line.Draw();

        Triangle triangle = new Triangle(1, 1, 5, 6);
        triangle.Draw();

        Rectangle rectangle = new Rectangle(1, 1, 2, 6);
        rectangle.Draw();
    }
}
class Figure
{
    protected int x;
    protected int y;

    public Figure(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

class Circle : Figure
{
    private int radius;

    public Circle(int x, int y, int radius) : base(x, y)
    {
        this.radius = radius;
    }

    public void Draw()
    {
        if (radius != 0)
            Console.WriteLine($"Circle: Radius: {radius}. Position: {x},{y}");
        else
            Console.WriteLine("Circle fails");
    }
}

class Line : Figure
{
    private int x1, y1;

    public Line(int x, int y, int x1, int y1) : base(x, y)
    {
        this.x1 = x1;
        this.y1 = y1;
    }

    public void Draw()
    {
        if (x1 != 0 || y1 != 0)
        {
            Console.WriteLine($"Line: First position: {x},{y}. Last position: {x1},{y1}");
        }
        else
            Console.WriteLine("Rectangle fails");
    }
}

class Triangle : Figure
{
    private int x1, y1, x2, y2, x3, y3;
    private int baseT;
    private int height;

    public Triangle(int x, int y, int baseT, int height) : base(x, y)
    {
        this.baseT = baseT;
        this.height = height;
    }

    public void Draw()
    {
        if (height != 0 && baseT != 0)
        {
            int baset2 = baseT / 2;
            x1 = x - baset2;
            y1 = y;
            x2 = x + baset2;
            y2 = y;
            x3 = x;
            y3 = y + height;
            Console.WriteLine($"Triangle: First position: {x1},{y1}. Middle position: {x3},{y3}. Last position: {x2},{y2}");
        }
        else
            Console.WriteLine("Triangle fails");
    }
}

class Rectangle : Figure
{
    private int width;
    private int length;
    private int x1, y1, x2, y2, x3, y3;

    public Rectangle(int x, int y, int width, int length) : base(x, y)
    {
        this.width = width;
        this.length = length;
    }
    public void Draw()
    {
        if (width != 0 && length != 0)
        {
            x1 = x + length;
            y1 = y;
            x2 = x;
            y2 = y + width;
            x3 = x + length;
            y3 = y + width;
            Console.WriteLine($"Rectangle: First position: {x},{y}. Second position: {x1},{y1}. Third position: {x2},{y2}. Last position: {x3},{y3}");
        }
        else
            Console.WriteLine("Rectangle fails");
    }
}