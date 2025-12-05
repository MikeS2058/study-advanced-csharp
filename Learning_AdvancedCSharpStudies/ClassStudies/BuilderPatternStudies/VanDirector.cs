namespace Learning_AdvancedCSharpStudies.ClassStudies.BuilderPatternStudies;

/// <summary>
///     Concrete director for van construction (VanDirector in UML).
/// </summary>
public class VanDirector : VehicleDirector
{
    public VanDirector(VehicleBuilder builder) : base(builder)
    {
        if (builder is not VanBuilder) throw new ArgumentException("Builder must be a VanBuilder", nameof(builder));
    }

    public override IVehicle Build()
    {
        List<string> features = new(4)
        {
            _builder.BuildBody(),
            _builder.BuildChassis(),
            _builder.BuildReinforcedStorageArea(),
            _builder.BuildWindows()
        };
        return new Van(features.ToArray());
    }
}