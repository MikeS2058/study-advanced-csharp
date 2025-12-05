namespace Learning_AdvancedCSharpStudies.ClassStudies.FactoryStudies.CompanyVehicles;

/// <summary>
///     Represents a box van, a concrete implementation of <see cref="AbstractVan" />.
/// </summary>
public class BoxVan : AbstractVan
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="BoxVan" /> class.
    /// </summary>
    public BoxVan()
    {
        Engine = "Diesel Inline-4";
        Colour = "White";
    }

    /// <summary>
    ///     Paints the box van with a new colour.
    /// </summary>
    public override void Paint()
    {
        Console.WriteLine($"Painting the Box Van {Colour}");
    }
}