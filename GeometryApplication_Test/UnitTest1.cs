namespace GeometryApplication_Test;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//Test Cases For area and perimeter of Square :
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

//Test Cases For area and perimeter of Rectangle : 
[TestClass]
public class RectangleTests
{
    [TestMethod]
    public void TestCalculateArea()
    {
        // Arrange
        double length = 5;
        double width = 4;
        Rectangle rectangle = new Rectangle(length, width);

        // Act
        double area = rectangle.CalculateArea();

        // Assert
        Assert.AreEqual(20, area);
    }

    [TestMethod]
    public void TestCalculatePerimeter()
    {
        // Arrange
        double length = 5;
        double width = 4;
        Rectangle rectangle = new Rectangle(length, width);

        // Act
        double perimeter = rectangle.CalculatePerimeter();

        // Assert
        Assert.AreEqual(18, perimeter);
    }
}
[TestClass]
public class RectangleTests2
{
    [TestMethod]
    public void TestCalculateArea()
    {
        // Arrange
        double length = 5;
        double width = 4;
        Rectangle rectangle = new Rectangle(length, width);

        // Act
        double area = rectangle.CalculateArea();

        // Assert
        Assert.AreEqual(20, area);
    }

    [TestMethod]
    public void TestCalculatePerimeter()
    {
        // Arrange
        double length = 5;
        double width = 4;
        Rectangle rectangle = new Rectangle(length, width);

        // Act
        double perimeter = rectangle.CalculatePerimeter();

        // Assert
        Assert.AreEqual(18, perimeter);
    }
}
[TestClass]
public class RectangleTests;
{
    [TestMethod]
    public void TestCalculateArea()
    {
        // Arrange
        double length = 2;
        double width = 4;
        Rectangle rectangle = new Rectangle(length, width);

        // Act
        double area = rectangle.CalculateArea();

        // Assert
        Assert.AreEqual(20, area);
    }

    [TestMethod]
    public void TestCalculatePerimeter()
    {
        // Arrange
        double length = 5;
        double width = 4;
        Rectangle rectangle = new Rectangle(length, width);

        // Act
        double perimeter = rectangle.Tes.CalculatePerimeter();

        // Assert
        Assert.AreEqual(18, perimeter);
    }
}