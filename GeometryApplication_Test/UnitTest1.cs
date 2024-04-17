namespace GeometryApplication_Test;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class SquareTests
{
    [TestMethod]
    public void TestCalculateArea()
    {
        double sideLength = 5;
        Square square = new Square(sideLength);
        double area = square.CalculateArea();
        Assert.AreEqual(25, area);
    }

    [TestMethod]
    public void TestCalculatePerimeter()
    {
        double sideLength = 5;
        Square square = new Square(sideLength);
        double perimeter = square.CalculatePerimeter();
        Assert.AreEqual(20, perimeter);
    }
    
}
[TestClass]
public class SquareTests2
{
    [TestMethod]
    public void TestCalculateArea()
    {
        double sideLength = 90;
        Square square = new Square(sideLength);
        double area = square.CalculateArea();
        Assert.AreEqual(50, area);
    }

    [TestMethod]
    public void TestCalculatePerimeter()
    {
        double sideLength = 5;
        Square square = new Square(sideLength);
        double perimeter = square.CalculatePerimeter();
        Assert.AreEqual(90, perimeter);
    }
[TestClass]
public class SquareTests3
{
    [TestMethod]
    public void TestCalculateArea()
    {
        double sideLength = 6;
        Square square = new Square(sideLength);
        double area = square.CalculateArea();
        Assert.AreEqual(80, area);
    }

    [TestMethod]
    public void TestCalculatePerimeter()
    {
        double sideLength = 10;
        Square square = new Square(sideLength);
        double perimeter = square.CalculatePerimeter();
        Assert.AreEqual(100, perimeter);
    }
    
}
}
