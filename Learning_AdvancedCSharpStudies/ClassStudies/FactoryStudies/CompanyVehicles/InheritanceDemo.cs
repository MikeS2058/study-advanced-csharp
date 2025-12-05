namespace Learning_AdvancedCSharpStudies.ClassStudies.FactoryStudies.CompanyVehicles;

/// <summary>
///     Demonstrates the vehicle inheritance hierarchy with various examples.
/// </summary>
public static class InheritanceDemo
{
    /// <summary>
    ///     Runs all demonstration examples for the vehicle inheritance hierarchy.
    /// </summary>
    public static void Run()
    {
        Console.WriteLine("=== Vehicle Inheritance Hierarchy Demo ===\n");

        DemonstrateCars();
        Console.WriteLine();
        DemonstrateVans();
        Console.WriteLine();
        DemonstratePolymorphism();
        Console.WriteLine();
        DemonstratePropertyAccess();
    }

    /// <summary>
    ///     Demonstrates creating and using different car types.
    /// </summary>
    private static void DemonstrateCars()
    {
        Console.WriteLine("--- Car Demonstrations ---");

        Saloon saloon = new();
        Console.WriteLine($"Saloon - Engine: {saloon.Engine}, Colour: {saloon.Colour}");
        saloon.Paint();

        Coupe coupe = new();
        Console.WriteLine($"Coupe - Engine: {coupe.Engine}, Colour: {coupe.Colour}");
        coupe.Paint();

        Sport sport = new();
        Console.WriteLine($"Sport - Engine: {sport.Engine}, Colour: {sport.Colour}");
        sport.Paint();
    }

    /// <summary>
    ///     Demonstrates creating and using different van types.
    /// </summary>
    private static void DemonstrateVans()
    {
        Console.WriteLine("--- Van Demonstrations ---");

        BoxVan boxVan = new();
        Console.WriteLine($"BoxVan - Engine: {boxVan.Engine}, Colour: {boxVan.Colour}");
        boxVan.Paint();

        Pickup pickup = new();
        Console.WriteLine($"Pickup - Engine: {pickup.Engine}, Colour: {pickup.Colour}");
        pickup.Paint();
    }

    /// <summary>
    ///     Demonstrates polymorphism by treating all vehicles as <see cref="IVehicle" />.
    /// </summary>
    private static void DemonstratePolymorphism()
    {
        Console.WriteLine("--- Polymorphism Demonstration ---");

        List<IVehicle> vehicles =
        [
            new Saloon(),
            new Coupe(),
            new Sport(),
            new BoxVan(),
            new Pickup()
        ];

        foreach (IVehicle vehicle in vehicles)
        {
            Console.Write($"{vehicle.GetType().Name}: ");
            vehicle.Paint();
        }
    }

    /// <summary>
    ///     Demonstrates modifying vehicle properties and painting with new colours.
    /// </summary>
    private static void DemonstratePropertyAccess()
    {
        Console.WriteLine("--- Property Modification Demonstration ---");

        Sport sport = new();
        Console.WriteLine($"Original colour: {sport.Colour}");
        sport.Paint();

        sport.Colour = "Metallic Blue";
        Console.WriteLine($"New colour: {sport.Colour}");
        sport.Paint();

        BoxVan boxVan = new();
        boxVan.Engine = "Electric";
        boxVan.Colour = "Green";
        Console.WriteLine($"Custom BoxVan - Engine: {boxVan.Engine}, Colour: {boxVan.Colour}");
        boxVan.Paint();
    }
}