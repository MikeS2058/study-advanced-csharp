namespace Learning_AdvancedCSharpStudies.ClassStudies.BuilderPatternStudies;

/// <summary>
///     Concrete builder for car parts (CarBuilder in UML).
/// </summary>
public class CarBuilder : VehicleBuilder
{
    public override string BuildBody()
    {
        return "Car Body Built";
    }

    public override string BuildChassis()
    {
        return "Car Chassis Built";
    }

    public override string BuildBoot()
    {
        return "Car Boot Built";
    }

    public override string BuildPassengerArea()
    {
        return "Car Passenger Area Built";
    }

    public override string BuildReinforcedStorageArea()
    {
        return "Car Reinforced Storage Area Built";
    }

    public override string BuildWindows()
    {
        return "Car Windows Built";
    }
}