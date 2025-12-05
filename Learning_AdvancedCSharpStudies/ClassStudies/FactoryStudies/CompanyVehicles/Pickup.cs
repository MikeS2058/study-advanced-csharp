﻿namespace Learning_AdvancedCSharpStudies.ClassStudies.FactoryStudies.CompanyVehicles;

/// <summary>
/// Represents a pickup truck, a concrete implementation of <see cref="AbstractVan"/>.
/// </summary>
public class Pickup : AbstractVan
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Pickup"/> class.
    /// </summary>
    public Pickup()
    {
        Engine = "V8 Turbo";
        Colour = "Black";
    }

    /// <summary>
    /// Paints the pickup truck with a new colour.
    /// </summary>
    public override void Paint()
    {
        Console.WriteLine($"Painting the Pickup {Colour}");
    }
}