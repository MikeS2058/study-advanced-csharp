namespace Learning_AdvancedCSharpStudies.ClassStudies.FactoryStudies.CompanyVehicles;

/// <summary>
///     Represents a saloon car, a concrete implementation of <see cref="AbstractCar" />.
/// </summary>
public class Saloon : AbstractCar
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Saloon" /> class.
    /// </summary>
    public Saloon()
    {
        Engine = "V6";
        Colour = "Silver";
    }

    /// <summary>
    ///     Paints the saloon car with a new colour.
    /// </summary>
    public override void Paint()
    {
        Console.WriteLine($"Painting the Saloon {Colour}");
    }
}