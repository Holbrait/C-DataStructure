// written by Holbrait
// 02/27/25

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(string color, double width, double height)
        : base(color)
    {
        Width = width;
        Height = height;
    }

    public override double GetArea()
    {
        return Width * Height;
    }

    public override string ToString()
    {
        return Color + " Rectangle, Width: " + Width + ", Height: " + Height + ", Area: " + GetArea();
    }
}
