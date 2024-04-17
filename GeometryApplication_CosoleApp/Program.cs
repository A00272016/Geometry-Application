using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.FeatureManagement;

class Program
{
    static void Main(string[] args)
    {
        var featureManagement = new Dictionary<string, string>
        {
            { "FeatureManagement:Square", "true"},
            { "FeatureManagement:Rectangle", "false"},
            { "FeatureManagement:Triangle", "true"}
        };

        IConfigurationRoot configuration = new ConfigurationBuilder().AddInMemoryCollection(featureManagement).Build();

        var services = new ServiceCollection();
        services.AddFeatureManagement(configuration);

        // Build the service provider
        var serviceProvider = services.BuildServiceProvider();

        // Resolve IFeatureManager from the service provider
        var featureManager = serviceProvider.GetRequiredService<IFeatureManager>();

        // Now you can use featureManager to check if a feature is enabled
        // For example:
        if (featureManager.IsEnabledAsync("Square").Result)
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
        
    }
}
