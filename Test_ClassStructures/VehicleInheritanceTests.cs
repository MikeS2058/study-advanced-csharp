using Learning_AdvancedCSharpStudies.ClassStudies.FactoryStudies.CompanyVehicles;

namespace Test_ClassStructures.InheritanceTests;

/// <summary>
///     Tests for the vehicle inheritance hierarchy.
/// </summary>
public class VehicleInheritanceTests
{
    #region Interface Implementation Tests

    [Fact]
    public void Saloon_ImplementsIVehicle()
    {
        // Arrange & Act
        IVehicle vehicle = new Saloon();

        // Assert
        Assert.NotNull(vehicle);
        Assert.IsAssignableFrom<IVehicle>(vehicle);
    }

    [Fact]
    public void Coupe_ImplementsIVehicle()
    {
        // Arrange & Act
        IVehicle vehicle = new Coupe();

        // Assert
        Assert.NotNull(vehicle);
        Assert.IsAssignableFrom<IVehicle>(vehicle);
    }

    [Fact]
    public void Sport_ImplementsIVehicle()
    {
        // Arrange & Act
        IVehicle vehicle = new Sport();

        // Assert
        Assert.NotNull(vehicle);
        Assert.IsAssignableFrom<IVehicle>(vehicle);
    }

    [Fact]
    public void BoxVan_ImplementsIVehicle()
    {
        // Arrange & Act
        IVehicle vehicle = new BoxVan();

        // Assert
        Assert.NotNull(vehicle);
        Assert.IsAssignableFrom<IVehicle>(vehicle);
    }

    [Fact]
    public void Pickup_ImplementsIVehicle()
    {
        // Arrange & Act
        IVehicle vehicle = new Pickup();

        // Assert
        Assert.NotNull(vehicle);
        Assert.IsAssignableFrom<IVehicle>(vehicle);
    }

    #endregion

    #region Inheritance Tests

    [Fact]
    public void Saloon_InheritsFromAbstractCar()
    {
        // Arrange & Act
        Saloon saloon = new();

        // Assert
        Assert.IsAssignableFrom<AbstractCar>(saloon);
        Assert.IsAssignableFrom<AbstractVehicle>(saloon);
    }

    [Fact]
    public void Coupe_InheritsFromAbstractCar()
    {
        // Arrange & Act
        Coupe coupe = new();

        // Assert
        Assert.IsAssignableFrom<AbstractCar>(coupe);
        Assert.IsAssignableFrom<AbstractVehicle>(coupe);
    }

    [Fact]
    public void Sport_InheritsFromAbstractCar()
    {
        // Arrange & Act
        Sport sport = new();

        // Assert
        Assert.IsAssignableFrom<AbstractCar>(sport);
        Assert.IsAssignableFrom<AbstractVehicle>(sport);
    }

    [Fact]
    public void BoxVan_InheritsFromAbstractVan()
    {
        // Arrange & Act
        BoxVan boxVan = new();

        // Assert
        Assert.IsAssignableFrom<AbstractVan>(boxVan);
        Assert.IsAssignableFrom<AbstractVehicle>(boxVan);
    }

    [Fact]
    public void Pickup_InheritsFromAbstractVan()
    {
        // Arrange & Act
        Pickup pickup = new();

        // Assert
        Assert.IsAssignableFrom<AbstractVan>(pickup);
        Assert.IsAssignableFrom<AbstractVehicle>(pickup);
    }

    #endregion

    #region Property Tests

    [Fact]
    public void Saloon_HasCorrectDefaultProperties()
    {
        // Arrange & Act
        Saloon saloon = new();

        // Assert
        Assert.Equal("V6", saloon.Engine);
        Assert.Equal("Silver", saloon.Colour);
    }

    [Fact]
    public void Coupe_HasCorrectDefaultProperties()
    {
        // Arrange & Act
        Coupe coupe = new();

        // Assert
        Assert.Equal("V8", coupe.Engine);
        Assert.Equal("Red", coupe.Colour);
    }

    [Fact]
    public void Sport_HasCorrectDefaultProperties()
    {
        // Arrange & Act
        Sport sport = new();

        // Assert
        Assert.Equal("V12", sport.Engine);
        Assert.Equal("Yellow", sport.Colour);
    }

    [Fact]
    public void BoxVan_HasCorrectDefaultProperties()
    {
        // Arrange & Act
        BoxVan boxVan = new();

        // Assert
        Assert.Equal("Diesel Inline-4", boxVan.Engine);
        Assert.Equal("White", boxVan.Colour);
    }

    [Fact]
    public void Pickup_HasCorrectDefaultProperties()
    {
        // Arrange & Act
        Pickup pickup = new();

        // Assert
        Assert.Equal("V8 Turbo", pickup.Engine);
        Assert.Equal("Black", pickup.Colour);
    }

    #endregion

    #region Property Modification Tests

    [Theory]
    [InlineData("V6", "Blue")]
    [InlineData("Electric", "Green")]
    [InlineData("Hybrid", "White")]
    public void Saloon_CanModifyProperties(string engine, string colour)
    {
        // Arrange
        Saloon saloon = new();

        // Act
        saloon.Engine = engine;
        saloon.Colour = colour;

        // Assert
        Assert.Equal(engine, saloon.Engine);
        Assert.Equal(colour, saloon.Colour);
    }

    [Theory]
    [InlineData("V12 Twin-Turbo", "Metallic Blue")]
    [InlineData("V10", "Orange")]
    public void Sport_CanModifyProperties(string engine, string colour)
    {
        // Arrange
        Sport sport = new();

        // Act
        sport.Engine = engine;
        sport.Colour = colour;

        // Assert
        Assert.Equal(engine, sport.Engine);
        Assert.Equal(colour, sport.Colour);
    }

    [Theory]
    [InlineData("Electric", "Green")]
    [InlineData("Diesel V6", "Silver")]
    public void BoxVan_CanModifyProperties(string engine, string colour)
    {
        // Arrange
        BoxVan boxVan = new();

        // Act
        boxVan.Engine = engine;
        boxVan.Colour = colour;

        // Assert
        Assert.Equal(engine, boxVan.Engine);
        Assert.Equal(colour, boxVan.Colour);
    }

    #endregion

    #region Polymorphism Tests

    [Fact]
    public void AllVehicles_CanBeTreatedAsIVehicle()
    {
        // Arrange
        List<IVehicle> vehicles =
        [
            new Saloon(),
            new Coupe(),
            new Sport(),
            new BoxVan(),
            new Pickup()
        ];

        // Act & Assert
        foreach (IVehicle vehicle in vehicles)
        {
            Assert.NotNull(vehicle.Engine);
            Assert.NotNull(vehicle.Colour);
            vehicle.Paint(); // Should not throw
        }
    }

    [Fact]
    public void AllCars_CanBeTreatedAsAbstractCar()
    {
        // Arrange
        List<AbstractCar> cars =
        [
            new Saloon(),
            new Coupe(),
            new Sport()
        ];

        // Act & Assert
        foreach (AbstractCar car in cars)
        {
            Assert.NotNull(car.Engine);
            Assert.NotNull(car.Colour);
            car.Paint(); // Should not throw
        }
    }

    [Fact]
    public void AllVans_CanBeTreatedAsAbstractVan()
    {
        // Arrange
        List<AbstractVan> vans =
        [
            new BoxVan(),
            new Pickup()
        ];

        // Act & Assert
        foreach (AbstractVan van in vans)
        {
            Assert.NotNull(van.Engine);
            Assert.NotNull(van.Colour);
            van.Paint(); // Should not throw
        }
    }

    #endregion

    #region Paint Method Tests

    [Fact]
    public void Saloon_PaintMethodExecutes()
    {
        // Arrange
        Saloon saloon = new();
        using StringWriter sw = new();
        Console.SetOut(sw);

        // Act
        saloon.Paint();

        // Assert
        string output = sw.ToString();
        Assert.Contains("Saloon", output);
        Assert.Contains(saloon.Colour, output);
    }

    [Fact]
    public void Coupe_PaintMethodExecutes()
    {
        // Arrange
        Coupe coupe = new();
        using StringWriter sw = new();
        Console.SetOut(sw);

        // Act
        coupe.Paint();

        // Assert
        string output = sw.ToString();
        Assert.Contains("Coupe", output);
        Assert.Contains(coupe.Colour, output);
    }

    [Fact]
    public void Sport_PaintMethodExecutes()
    {
        // Arrange
        Sport sport = new();
        using StringWriter sw = new();
        Console.SetOut(sw);

        // Act
        sport.Paint();

        // Assert
        string output = sw.ToString();
        Assert.Contains("Sport", output);
        Assert.Contains(sport.Colour, output);
    }

    [Fact]
    public void BoxVan_PaintMethodExecutes()
    {
        // Arrange
        BoxVan boxVan = new();
        using StringWriter sw = new();
        Console.SetOut(sw);

        // Act
        boxVan.Paint();

        // Assert
        string output = sw.ToString();
        Assert.Contains("Box Van", output);
        Assert.Contains(boxVan.Colour, output);
    }

    [Fact]
    public void Pickup_PaintMethodExecutes()
    {
        // Arrange
        Pickup pickup = new();
        using StringWriter sw = new();
        Console.SetOut(sw);

        // Act
        pickup.Paint();

        // Assert
        string output = sw.ToString();
        Assert.Contains("Pickup", output);
        Assert.Contains(pickup.Colour, output);
    }

    #endregion

    #region Edge Case Tests

    [Fact]
    public void Vehicle_CanHaveEmptyEngine()
    {
        // Arrange
        Saloon saloon = new();

        // Act
        saloon.Engine = string.Empty;

        // Assert
        Assert.Equal(string.Empty, saloon.Engine);
    }

    [Fact]
    public void Vehicle_CanHaveEmptyColour()
    {
        // Arrange
        Sport sport = new();

        // Act
        sport.Colour = string.Empty;

        // Assert
        Assert.Equal(string.Empty, sport.Colour);
    }

    [Fact]
    public void MultipleInstances_AreIndependent()
    {
        // Arrange
        Saloon saloon1 = new();
        Saloon saloon2 = new();

        // Act
        saloon1.Colour = "Blue";
        saloon2.Colour = "Green";

        // Assert
        Assert.Equal("Blue", saloon1.Colour);
        Assert.Equal("Green", saloon2.Colour);
        Assert.NotEqual(saloon1.Colour, saloon2.Colour);
    }

    #endregion
}