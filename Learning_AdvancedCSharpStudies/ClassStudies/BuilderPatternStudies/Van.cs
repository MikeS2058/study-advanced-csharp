namespace Learning_AdvancedCSharpStudies.ClassStudies.BuilderPatternStudies;

public class Van(string[] features) : VehicleBase
{
    public override string VehicleType => "Van";
    public override IReadOnlyList<string> VehicleFeatures { get; init; } = ValidateFeatures(features);
}