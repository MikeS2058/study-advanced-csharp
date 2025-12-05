namespace Learning_AdvancedCSharpStudies.ClassStudies.BuilderPatternStudies;

/// <summary>
///     Client code that uses director to build a car (CarClient in UML).
/// </summary>
public class CarClient
{
    public void BuildCar()
    {
        CarBuilder builder = new();
        CarDirector director = new(builder);
        IVehicle car = director.Build();
        Console.WriteLine(car);
    }
}