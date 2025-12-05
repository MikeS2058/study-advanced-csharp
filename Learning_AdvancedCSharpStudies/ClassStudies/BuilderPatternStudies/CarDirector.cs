namespace Learning_AdvancedCSharpStudies.ClassStudies.BuilderPatternStudies;

/// <summary>
///     Concrete director for car construction (CarDirector in UML).
/// </summary>
public class CarDirector : VehicleDirector
{
    public CarDirector(VehicleBuilder builder) : base(builder)
    {
        if (builder is not CarBuilder) throw new ArgumentException("Builder must be a CarBuilder", nameof(builder));
    }

    public override IVehicle Build()
    {
        List<string> features = new(6)
        {
            _builder.BuildBody(),
            _builder.BuildChassis(),
            _builder.BuildBoot(),
            _builder.BuildPassengerArea(),
            _builder.BuildReinforcedStorageArea(),
            _builder.BuildWindows()
        };
        return new Car(features.ToArray());
    }
}