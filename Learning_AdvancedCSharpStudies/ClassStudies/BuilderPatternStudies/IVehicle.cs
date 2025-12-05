namespace Learning_AdvancedCSharpStudies.ClassStudies.BuilderPatternStudies;

public interface IVehicle
{
    string VehicleType { get; }
    IReadOnlyList<string> VehicleFeatures { get; init; }
}