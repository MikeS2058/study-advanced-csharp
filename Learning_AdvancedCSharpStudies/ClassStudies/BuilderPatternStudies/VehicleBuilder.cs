namespace Learning_AdvancedCSharpStudies.ClassStudies.BuilderPatternStudies;

/// <summary>
///     Abstract builder defining the interface for creating vehicle parts (VehicleBuilder in UML).
/// </summary>
public abstract class VehicleBuilder
{
    public virtual string BuildBody()
    {
        return string.Empty;
    }

    public virtual string BuildChassis()
    {
        return string.Empty;
    }

    public virtual string BuildBoot()
    {
        return string.Empty;
    }

    public virtual string BuildPassengerArea()
    {
        return string.Empty;
    }

    public virtual string BuildWindows()
    {
        return string.Empty;
    }

    public virtual string BuildReinforcedStorageArea()
    {
        return string.Empty;
    }
}