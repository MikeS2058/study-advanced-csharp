namespace Learning_AdvancedCSharpStudies.ClassStudies.FactoryStudies.CompanyVehicles;

/// <summary>
///     Abstract base class for all van types, inheriting from <see cref="AbstractVehicle" />.
/// </summary>
public abstract class AbstractVan : AbstractVehicle
{
    /// <summary>
    ///     Gets or sets the engine type of the van.
    /// </summary>
    public new string Engine { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the colour of the van.
    /// </summary>
    public new string Colour { get; set; } = string.Empty;

    /// <summary>
    ///     Paints the van with a new colour.
    /// </summary>
    public override void Paint()
    {
        Console.WriteLine($"Painting the van {Colour}");
    }
}