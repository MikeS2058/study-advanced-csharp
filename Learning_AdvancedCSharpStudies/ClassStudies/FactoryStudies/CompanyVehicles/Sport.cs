﻿namespace Learning_AdvancedCSharpStudies.ClassStudies.FactoryStudies.CompanyVehicles;

/// <summary>
/// Represents a sport car, a concrete implementation of <see cref="AbstractCar"/>.
/// </summary>
public class Sport : AbstractCar
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Sport"/> class.
    /// </summary>
    public Sport()
    {
        Engine = "V12";
        Colour = "Yellow";
    }

    /// <summary>
    /// Paints the sport car with a new colour.
    /// </summary>
    public override void Paint()
    {
        Console.WriteLine($"Painting the Sport car {Colour}");
    }
}