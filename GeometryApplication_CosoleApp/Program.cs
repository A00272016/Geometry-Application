using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.FeatureManagement;

class Program
{
    static void Main(string[] args)
    {
        var featureManagement = new Dictionary<string, string>
        {
            { "FeatureManagement:Square", "false"},
            { "FeatureManagement:Rectangle", "false"},
            { "FeatureManagement:Triangle", "true"}
        };

        IConfigurationRoot configuration = new ConfigurationBuilder().AddInMemoryCollection(featureManagement).Build();

        var services = new ServiceCollection();
        services.AddFeatureManagement(configuration);

        var serviceProvider = services.BuildServiceProvider();
        var featureManager = serviceProvider.GetRequiredService<IFeatureManager>();

        if (await featureManager.IsEnabledAsync("Square").Result)
        {
            // var square = new Square(5);
            Console.WriteLine("Square feature is enabled.");
        }
        else
        {
            Console.WriteLine("Square feature is disabled.");
        }
        Console.WriteLine("Enter the side length of the Square:");
        double side = Convert.ToDouble(Console.ReadLine());

        Square square = new Square(side);

        Console.WriteLine($"Area of the Square: {square.CalculateArea()}");
        Console.WriteLine($"Perimeter of the Square: {square.CalculatePerimeter()}");

        if (featureManager.IsEnabledAsync("Rectangle").Result)
        {
            // var square = new Square(5);
            Console.WriteLine("Rectangle feature is enabled.");
        }
        else
        {
            Console.WriteLine("Rectangle feature is disabled.");
        }
        Console.WriteLine("Enter the side length of the Rectangle:");
        double length = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the side length of the Rectangle:");
        double width = Convert.ToDouble(Console.ReadLine());

        Rectangle rectangle = new Rectangle(length,width);

        Console.WriteLine($"Area of the Square: {rectangle.CalculateArea()}");
        Console.WriteLine($"Perimeter of the Square: {rectangle.CalculatePerimeter()}");

        if (featureManager.IsEnabledAsync("Triangle").Result)
        {
            Console.WriteLine("Triangle feature is enabled.");
        }
        else
        {
            Console.WriteLine("Triangle feature is disabled.");
        }
        Console.WriteLine("Enter the side1 of the Triangle:");
        double side1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the side2 of the Triangle:");
        double side2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the side3 of the Triangle:");
        double side3 = Convert.ToDouble(Console.ReadLine());

        Triangle triangle = new Triangle(side1,side2,side3);

        Console.WriteLine($"Area of the Square: {triangle.CalculateArea()}");
        Console.WriteLine($"Perimeter of the Square: {triangle.CalculatePerimeter()}");
    }
}
