
namespace GeometryApplication_Test;

[TestClass]
public class SquareTests
{
    [TestMethod]
    public void Test_Area_1()
    {
        double sideLength = 5;
        Square square = new Square(sideLength);
        double area = square.CalculateArea();
        Assert.AreEqual(25, area);
    }

    [TestMethod]
    public void Test_Area_2()
    {
        double sideLength = 0;
        Square square = new Square(sideLength);
        double area = square.CalculateArea();
        Assert.AreEqual(0, area);
    }

    [TestMethod]
    public void Test_Area_3()
    {
        double sideLength = -5;
        Square square = new Square(sideLength);
        double area = square.CalculateArea();
        Assert.AreEqual(25, area); 
    }

    [TestMethod]
    public void Test_Area_4()
    {
        double sideLength = 1000;
        Square square = new Square(sideLength);
        double area = square.CalculateArea();
        Assert.AreEqual(1000000, area);
    }
    [TestMethod]
    public void Test_Permineter_1()
    {
        // Arrange
        double sideLength = 5;
        Square square = new Square(sideLength);

        // Act
        double perimeter = square.CalculatePerimeter();

        // Assert
        Assert.AreEqual(20, perimeter);
    }

    [TestMethod]
    public void Test_Permineter_2()
    {
        // Arrange
        double sideLength = 0;
        Square square = new Square(sideLength);

        // Act
        double perimeter = square.CalculatePerimeter();

        // Assert
        Assert.AreEqual(0, perimeter);
    }

    [TestMethod]
    public void Test_Permineter_3()
    {
        // Arrange
        double sideLength = -5;
        Square square = new Square(sideLength);
        double perimeter = square.CalculatePerimeter();
        Assert.AreEqual(-20, perimeter); // Assuming the calculation handles negative side lengths correctly
    }

    [TestMethod]
    public void Test_Permineter_4()
    {
        double sideLength = 1000;
        Square square = new Square(sideLength);
        double perimeter = square.CalculatePerimeter();
        Assert.AreEqual(4000, perimeter);
    }
}