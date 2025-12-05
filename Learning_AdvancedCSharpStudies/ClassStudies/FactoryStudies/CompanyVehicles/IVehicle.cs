namespace Learning_AdvancedCSharpStudies.ClassStudies.FactoryStudies.CompanyVehicles;

/// <summary>
///     Defines the contract for all vehicle types.
/// </summary>
public interface IVehicle
{
    /// <summary>
    ///     Gets or sets the engine type of the vehicle.
    /// </summary>
    string Engine { get; set; }

    /// <summary>
    ///     Gets or sets the colour of the vehicle.
    /// </summary>
    string Colour { get; set; }

    /// <summary>
    ///     Paints the vehicle with a new colour.
    /// </summary>
    void Paint();
}