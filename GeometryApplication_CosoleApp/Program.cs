using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FeatureManagement;

var featureManagement = new Dictionary<string, string> {{ "FeatureManagement:Square", "false"}, { "FeatureManagement:Rectangle", "false"}, { "FeatureManagement:Triangle", "true"}};

IConfigurationRoot configuration = new ConfigurationBuilder().AddInMemoryCollection(featureManagement).Build();
var services = new ServiceCollection();
services.AddFeatureManagement(configuration);
var serviceProvider = services.BuildServiceProvider();

var featureManager = serviceProvider.GetRequiredService<IFeatureManagerSnapshot>();
if (await featureManager.IsEnabledAsync("Square"))
{
Console.WriteLine("Enter the side length of the Square:");
double side = Convert.ToDouble(Console.ReadLine());

Square square = new Square(side);

Console.WriteLine($"Area of the Square: {square.CalculateArea()}");
Console.WriteLine($"Perimeter of the Square: {square.CalculatePerimeter()}");
}
if (await featureManager.IsEnabledAsync("Rectangle"))
{
Console.WriteLine("Enter the side length of the rectangle:");
double length = Convert.ToDouble(Console.ReadLine());
double width = Convert.ToDouble(Console.ReadLine());

Rectangle rectangle = new Rectangle(length,width);

Console.WriteLine($"Area of the Square: {rectangle.CalculateArea()}");
Console.WriteLine($"Perimeter of the Square: {rectangle.CalculatePerimeter()}");
}
if (await featureManager.IsEnabledAsync("Triangle"))
{
Console.WriteLine("Enter the side length of the triangle:");
double side1 = Convert.ToDouble(Console.ReadLine());
double side2 = Convert.ToDouble(Console.ReadLine());
double side3 = Convert.ToDouble(Console.ReadLine());

Rectangle rectangle = new Rectangle(side1,side2,side3);

Console.WriteLine($"Area of the triangle: {triangle.CalculateArea()}");
Console.WriteLine($"Perimeter of the triangle: {triangle.CalculatePerimeter()}");
}