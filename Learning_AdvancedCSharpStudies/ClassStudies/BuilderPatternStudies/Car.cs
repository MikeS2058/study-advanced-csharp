namespace Learning_AdvancedCSharpStudies.ClassStudies.BuilderPatternStudies;

public class Car(string[] features) : VehicleBase
{
    public override string VehicleType => "Car";
    public override IReadOnlyList<string> VehicleFeatures { get; init; } = ValidateFeatures(features);
}