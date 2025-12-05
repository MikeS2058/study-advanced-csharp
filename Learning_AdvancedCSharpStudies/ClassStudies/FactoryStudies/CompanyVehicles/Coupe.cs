﻿namespace Learning_AdvancedCSharpStudies.ClassStudies.FactoryStudies.CompanyVehicles;

/// <summary>
/// Represents a coupe car, a concrete implementation of <see cref="AbstractCar"/>.
/// </summary>
public class Coupe : AbstractCar
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Coupe"/> class.
    /// </summary>
    public Coupe()
    {
        Engine = "V8";
        Colour = "Red";
    }

    /// <summary>
    /// Paints the coupe car with a new colour.
    /// </summary>
    public override void Paint()
    {
        Console.WriteLine($"Painting the Coupe {Colour}");
    }
}