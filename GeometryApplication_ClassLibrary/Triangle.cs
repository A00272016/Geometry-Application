//A00272016 Milan Pandya
public class Triangle : IShape
{
    private double side1;
    private double side2;
    private double side3;

    public Triangle(double side1, double side2, double side3)
    {
        this.side1 = side1;
        this.side2 = side2;
        this.side3 = side3;
    }

    public double CalculateArea()
    {
        double s = (side1 + side2 + side3) / 2;
        double area = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        return area;   
    }

    public double CalculatePerimeter()
    {
        return side1 + side2 + side3;
    }
}