namespace Learning_AdvancedCSharpStudies.ClassStudies.BuilderPatternStudies;

public abstract class VehicleBase : IVehicle
{
    public abstract string VehicleType { get; }
    public abstract IReadOnlyList<string> VehicleFeatures { get; init; }

    protected static string[] ValidateFeatures(string[] features)
    {
        ArgumentNullException.ThrowIfNull(features);
        return features.Length == 0
            ? throw new ArgumentException("Car must have at least one feature.", nameof(features))
            : features;
    }

    public override string ToString()
    {
        return $"{VehicleType} with features: {string.Join(", ", VehicleFeatures)}";
    }
}