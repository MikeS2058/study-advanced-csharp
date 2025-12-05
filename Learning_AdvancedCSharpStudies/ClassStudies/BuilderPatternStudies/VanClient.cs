namespace Learning_AdvancedCSharpStudies.ClassStudies.BuilderPatternStudies;

/// <summary>
///     Client code that uses director to build a van (VanClient in UML).
/// </summary>
public class VanClient
{
    public void BuildVan()
    {
        VanBuilder builder = new();
        VanDirector director = new(builder);
        IVehicle van = director.Build();
        Console.WriteLine(van);
    }
}