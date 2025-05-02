// written by Holbrait
// 02/27/25

public abstract class Shape
{
    public string Color { get; set; }

    public Shape(string color)
    {
        Color = color;
    }

    public abstract double GetArea();

    public override string ToString()
    {
        return Color + " Shape";
    }
}
