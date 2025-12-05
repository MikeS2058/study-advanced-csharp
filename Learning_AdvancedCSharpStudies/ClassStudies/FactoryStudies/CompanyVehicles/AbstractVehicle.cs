namespace Learning_AdvancedCSharpStudies.ClassStudies.FactoryStudies.CompanyVehicles;

/// <summary>
///     Abstract base class for all vehicles, providing common properties and behavior.
/// </summary>
public abstract class AbstractVehicle : IVehicle
{
    /// <summary>
    ///     Gets or sets the engine type of the vehicle.
    /// </summary>
    public string Engine { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the colour of the vehicle.
    /// </summary>
    public string Colour { get; set; } = string.Empty;

    /// <summary>
    ///     Paints the vehicle with a new colour.
    /// </summary>
    public virtual void Paint()
    {
        Console.WriteLine($"Painting the vehicle {Colour}");
    }
}