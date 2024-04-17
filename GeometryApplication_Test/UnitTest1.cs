//A00272016 Milan Pandya
namespace GeometryApplication_Test;

//Test Cases For area and permiter of Square :-
//Test Cases Aera of Square starts Here:
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
    //Test Cases Perimeter of Square starts Here:
    [TestMethod]
    public void Test_Permineter_1()
    {
        double sideLength = 5;
        Square square = new Square(sideLength);
        double perimeter = square.CalculatePerimeter();
        Assert.AreEqual(20, perimeter);
    }

    [TestMethod]
    public void Test_Permineter_2()
    {
        double sideLength = 0;
        Square square = new Square(sideLength);
        double perimeter = square.CalculatePerimeter();
        Assert.AreEqual(0, perimeter);
    }

    [TestMethod]
    public void Test_Permineter_3()
    {
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
//Test Cases For area and permiter of Rectangle :-
//Test Cases Aera of Rectangle starts Here:
[TestClass]
public class RectangleTests
{
    [TestMethod]
    public void Test_Area_rectangle_1()
    {
        double length = 5;
        double width = 4;
        Rectangle rectangle = new Rectangle(length, width);
        double area = rectangle.CalculateArea();
        Assert.AreEqual(20, area);
    }

    [TestMethod]
    public void Test_Area_rectangle_2()
    {
        double length = 0;
        double width = 0;
        Rectangle rectangle = new Rectangle(length, width);
        double area = rectangle.CalculateArea();
        Assert.AreEqual(0, area);
    }

    [TestMethod]
    public void Test_Area_rectangle_3()
    {
        double length = -5;
        double width = -4;
        Rectangle rectangle = new Rectangle(length, width);
        double area = rectangle.CalculateArea();
        Assert.AreEqual(20, area); 
    }

    [TestMethod]
    public void Test_Area_rectangle_4()
    {
        double length = 1000;
        double width = 500;
        Rectangle rectangle = new Rectangle(length, width);
        double area = rectangle.CalculateArea();
        Assert.AreEqual(500000, area);
    }
    //Test Cases Perimeter of Rectangle starts Here:
    [TestMethod]
    public void Test_Permineter_Rectangle_1()
    {
        double length = 5;
        double width = 4;
        Rectangle rectangle = new Rectangle(length, width);
        double perimeter = rectangle.CalculatePerimeter();
        Assert.AreEqual(18, perimeter);
    }

    [TestMethod]
    public void Test_Permineter_Rectangle_2()
    {
        double length = 0;
        double width = 0;
        Rectangle rectangle = new Rectangle(length, width);
        double perimeter = rectangle.CalculatePerimeter();
        Assert.AreEqual(0, perimeter);
    }

    [TestMethod]
    public void Test_Permineter_Rectangle_3()
    {
        double length = -5;
        double width = -4;
        Rectangle rectangle = new Rectangle(length, width);
        double perimeter = rectangle.CalculatePerimeter();
        Assert.AreEqual(-18, perimeter); // Assuming the calculation handles negative dimensions correctly
    }

    [TestMethod]
    public void Test_Permineter_Rectangle_4()
    {        
        double length = 1000;
        double width = 500;
        Rectangle rectangle = new Rectangle(length, width);
        double perimeter = rectangle.CalculatePerimeter();
        Assert.AreEqual(3000, perimeter);
    }
}
//Test Cases For area and permiter of Triangle :-
//Test Cases Aera of Triangle starts Here:
[TestClass]
public class TriangleTests
{
    [TestMethod]
    public void Test_Area_triangle_1()
    {
        Triangle triangle = new Triangle(3, 3, 3);
        double area = triangle.CalculateArea();
        Assert.AreEqual(3.8971143170299753, area, 0.0001); // Expected area of an equilateral triangle with side length 3
    }

    [TestMethod]
    public void Test_Area_triangle_2()
    {
        Triangle triangle = new Triangle(3, 4, 5);
        double area = triangle.CalculateArea();
        Assert.AreEqual(6, area); // Expected area of a right triangle with sides 3, 4, and 5
    }

    [TestMethod]
    public void Test_Area_triangle_3()
    {
        Triangle triangle = new Triangle(7, 8, 10);
        double area = triangle.CalculateArea();
        Assert.AreEqual(27.8107, area, 0.0001); // Expected area of a scalene triangle with sides 7, 8, and 10
    }

    [TestMethod]
    public void Test_Area_triangle_4()
    {
        Triangle triangle = new Triangle(0, 4, 4);
        double area = triangle.CalculateArea();
        Assert.AreEqual(0, area); 
    }
    //Test Cases Permimeter of Triangle starts Here:
     [TestMethod]
    public void Test_Permineter_triangle_1()
    {
        Triangle triangle = new Triangle(3, 3, 3);
        double perimeter = triangle.CalculatePerimeter();
        Assert.AreEqual(9, perimeter); // Expected perimeter of an equilateral triangle with side length 3
    }

    [TestMethod]
    public void Test_Permineter_triangle_2()
    {
        Triangle triangle = new Triangle(3, 4, 5);
        double perimeter = triangle.CalculatePerimeter();
        Assert.AreEqual(12, perimeter); // Expected perimeter of a right triangle with sides 3, 4, and 5
    }

    [TestMethod]
    public void Test_Permineter_triangle_3()
    {
        Triangle triangle = new Triangle(7, 8, 10);
        double perimeter = triangle.CalculatePerimeter();
        Assert.AreEqual(25, perimeter); // Expected perimeter of a scalene triangle with sides 7, 8, and 10
    }

    [TestMethod]
    public void Test_Permineter_triangle_4()
    {
        Triangle triangle = new Triangle(0, 4, 4);
        double perimeter = triangle.CalculatePerimeter();
        Assert.AreEqual(8, perimeter); 
    }
}
