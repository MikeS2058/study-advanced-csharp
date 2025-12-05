namespace Learning_AdvancedCSharpStudies.ClassStudies.BuilderPatternStudies;

#region VehicleClasses

public interface IVehicle
{
    string VehicleType { get; }
    IReadOnlyList<string> VehicleFeatures { get; init; }
    string? ToString();
}

public abstract class VehicleBase : IVehicle
{
    public abstract string VehicleType { get; }
    public abstract IReadOnlyList<string> VehicleFeatures { get; init; }

    protected static string[] ValidateFeatures(string[] features)
    {
        ArgumentNullException.ThrowIfNull(features);
        if (features.Length == 0)
        {
            throw new ArgumentException("Car must have at least one feature.", nameof(features));
        }

        return features;
    }
}

public class Van(string[] features) : VehicleBase
{
    public override string VehicleType => "Van";
    public override IReadOnlyList<string> VehicleFeatures { get; init; } = ValidateFeatures(features);
}

public class Car(string[] features) : VehicleBase
{
    public override string VehicleType => "Car";
    public override IReadOnlyList<string> VehicleFeatures { get; init; } = ValidateFeatures(features);
}

#endregion

#region DirectorClasses

public abstract class VehicleDirector : VehicleBuilder
{
    public abstract IVehicle Build();
}

public class CarDirector : VehicleDirector
{
    private readonly VehicleBuilder _builder;

    public CarDirector(VehicleBuilder? builder)
    {
        ArgumentNullException.ThrowIfNull(builder);
        if (builder is not CarBuilder)
        {
            throw new ArgumentException("Builder must be a CarBuilder", nameof(builder));
        }

        _builder = builder;
    }

    public override IVehicle Build()
    {
        _builder.BuildBody();
        _builder.BuildChassis();
        _builder.BuildBoot();
        _builder.BuildPassengerArea();
        _builder.BuildWindows();
        return _builder.Vehicle ?? throw new InvalidOperationException("Vehicle not built");
    }
}

public class VanDirector : VehicleDirector
{
    private readonly VehicleBuilder _builder;

    public VanDirector(VehicleBuilder? builder)
    {
        ArgumentNullException.ThrowIfNull(builder);
        if (builder is not VanBuilder)
        {
            throw new ArgumentException("Builder must be a VanBuilder", nameof(builder));
        }

        _builder = builder;
    }

    public override IVehicle Build()
    {
        _builder.BuildBody();
        _builder.BuildChassis();
        _builder.BuildWindows();
        return _builder.Vehicle ?? throw new InvalidOperationException("Vehicle not built");
    }
}

#endregion

#region BuilderClasses

public abstract class VehicleBuilder
{
    public IVehicle? Vehicle { get; protected set; }
    public List<string>[] Features { get; protected set; } = new List<string>[5];

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

    protected virtual string BuildReinforcedStorageArea()
    {
        return string.Empty;
    }
}

public class CarBuilder : VehicleBuilder
{
    public override string BuildBody()
    {
        base.BuildBody();
        return "Car Body Built";
    }

    public override string BuildChassis()
    {
        base.BuildChassis();
        return "Car Chassis Built";
    }

    public override string BuildBoot()
    {
        base.BuildBoot();
        return "Car Boot Built";
    }


    public override string BuildPassengerArea()
    {
        base.BuildPassengerArea();
        return "Car Passenger Area Built";
    }

    protected override string BuildReinforcedStorageArea()
    {
        base.BuildReinforcedStorageArea();
        return "Car Reinforced Storage Area Built";
    }

    public override string BuildWindows()
    {
        base.BuildWindows();
        return "Car Windows Built";
    }
}

public class VanBuilder : VehicleBuilder
{
    public override string BuildBody()
    {
        base.BuildBody();
        return "Van Body Built";
    }

    public override string BuildChassis()
    {
        base.BuildChassis();
        return "Van Chassis Built";
    }

    protected override string BuildReinforcedStorageArea()
    {
        base.BuildReinforcedStorageArea();
        return "Van Reinforced Storage Area Built";
    }

    public override string BuildWindows()
    {
        base.BuildWindows();
        return "Van Windows Built";
    }
}

#endregion

#region ClientClasses

public class CarClient
{
}

public class VanClient
{
}

#endregion