namespace Learning_AdvancedCSharpStudies.ClassStudies.BuilderPatternStudies;

/// <summary>
///     Concrete builder for van parts (VanBuilder in UML).
/// </summary>
public class VanBuilder : VehicleBuilder
{
    public override string BuildBody()
    {
        return "Van Body Built";
    }

    public override string BuildChassis()
    {
        return "Van Chassis Built";
    }

    public override string BuildReinforcedStorageArea()
    {
        return "Van Reinforced Storage Area Built";
    }

    public override string BuildWindows()
    {
        return "Van Windows Built";
    }
}