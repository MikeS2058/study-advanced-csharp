# Inheritance Studies - Vehicle Hierarchy

## Overview

This implementation demonstrates a multi-level inheritance hierarchy for vehicles, showcasing abstract classes, interfaces, and polymorphism in C#.

## Class Hierarchy

```
IVehicle (interface)
    ↑
AbstractVehicle (abstract class)
    ↑
    ├── AbstractCar (abstract class)
    │       ↑
    │       ├── Saloon (concrete)
    │       ├── Coupe (concrete)
    │       └── Sport (concrete)
    │
    └── AbstractVan (abstract class)
            ↑
            ├── BoxVan (concrete)
            └── Pickup (concrete)
```

## Components

### IVehicle Interface
- Defines the contract for all vehicles
- Properties: `Engine`, `Colour`
- Method: `Paint()`

### AbstractVehicle
- Base abstract class implementing `IVehicle`
- Provides default implementation of properties and `Paint()` method
- Serves as the foundation for all vehicle types

### AbstractCar
- Abstract class for car-specific behavior
- Inherits from `AbstractVehicle`
- Overrides `Paint()` to provide car-specific painting behavior

### AbstractVan
- Abstract class for van-specific behavior
- Inherits from `AbstractVehicle`
- Overrides `Paint()` to provide van-specific painting behavior

### Concrete Classes

#### Car Implementations
- **Saloon**: Family sedan with V6 engine, default Silver color
- **Coupe**: Two-door sports coupe with V8 engine, default Red color
- **Sport**: High-performance sports car with V12 engine, default Yellow color

#### Van Implementations
- **BoxVan**: Commercial delivery van with Diesel Inline-4 engine, default White color
- **Pickup**: Pickup truck with V8 Turbo engine, default Black color

## Key Concepts Demonstrated

1. **Interface-Based Programming**: All vehicles implement `IVehicle`
2. **Abstract Classes**: `AbstractVehicle`, `AbstractCar`, and `AbstractVan` provide shared behavior
3. **Polymorphism**: Each concrete class can override `Paint()` method
4. **Inheritance Hierarchy**: Multi-level inheritance (3 levels)
5. **Encapsulation**: Properties with getters and setters
6. **Code Reuse**: Common vehicle properties defined once in base classes

## Usage Example

```csharp
// Create different vehicle instances
IVehicle saloon = new Saloon();
IVehicle sport = new Sport();
IVehicle boxVan = new BoxVan();

// Call Paint method polymorphically
saloon.Paint();  // Output: Painting the Saloon Silver
sport.Paint();   // Output: Painting the Sport car Yellow
boxVan.Paint();  // Output: Painting the Box Van White

// Access properties
Console.WriteLine($"{saloon.Engine}"); // Output: V6
Console.WriteLine($"{sport.Colour}");  // Output: Yellow
```

## Design Benefits

- **Maintainability**: Changes to common vehicle behavior only need to be made in base classes
- **Extensibility**: New vehicle types can be added by extending abstract classes
- **Type Safety**: Interface ensures all vehicles have required properties and methods
- **Flexibility**: Polymorphism allows treating different vehicle types uniformly

## Implementation Notes

- All classes follow file-scoped namespace convention
- Full XML documentation provided for IntelliSense support
- Default values set in constructors for realistic vehicle configurations
- Virtual/override modifiers used appropriately for polymorphic behavior