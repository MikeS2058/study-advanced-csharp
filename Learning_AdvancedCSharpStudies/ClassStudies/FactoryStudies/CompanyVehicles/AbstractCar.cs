﻿namespace Learning_AdvancedCSharpStudies.ClassStudies.FactoryStudies.CompanyVehicles;

/// <summary>
/// Abstract base class for all car types, inheriting from <see cref="AbstractVehicle"/>.
/// </summary>
public abstract class AbstractCar : AbstractVehicle
{
    /// <summary>
    /// Gets or sets the engine type of the car.
    /// </summary>
    public new string Engine { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the colour of the car.
    /// </summary>
    public new string Colour { get; set; } = string.Empty;

    /// <summary>
    /// Paints the car with a new colour.
    /// </summary>
    public override void Paint()
    {
        Console.WriteLine($"Painting the car {Colour}");
    }
}