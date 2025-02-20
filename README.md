# Rusty.Quantities
A C# struct library of scalar physics quantities, intended to be used for custom character controllers in the [Godot game engine](https://github.com/godotengine/godot), but designed to be engine-agnostic.

## Features
### Quantities
The following quantities are supported:
- Time
- Distance
- Speed
- Acceleration

### Struct Contents
All structs are based on the `double` type. They contain various methods and operators:
- Implicit conversion operators to and from the following types: `bool`, `sbyte`, `byte`, `short`, `ushort`, `int`, `uint`, `long`, `ulong`, `float`, `double`, `decimal`, `char` and `string`.

- Mathematical operators `+`, `-`, `*`, `/`, `%`, `++` and `--`.

- Comparison operators `==`, `!=`, `<`, `>`, `>=` and `<=`.

- Formula methods, allowing for easy calculation of physics quantities from any valid combination of time, distance, constant, start or end speed and acceleration.

- Convenience math methods, such as:
  - Numeric functions: `Abs`,  `Sign`, `Truncate`, `Frac` and `Dist`.
  - Advanced math operators: `Sqrt` and `Pow`.
  - Rounding methods: `Round`, `Floor` and `Ceil`.
  - Trigonometric functions: `Sin`, `Cos` and `Tan`.
  - Interpolation functions: `Step` and `Lerp`.

- Convenience properties: `Zero`, `One`, `Pi` and `TwoPi`.

## Usage
Here's an example for how to calculate an acceleration from distance, time and start speed.

    using Rusty.Quantities;
    
    public class Test
    {
        public Acceleration Calculate()
        {
            Distance s = 10;
            Time t = 5;
            Speed u = 30;
            return Acceleration.AccelerationFromSTU(s, t, u);
        }
    }
   
For further details: all structs and their properties, methods and operators have been documented with a short summary.

## Planned Features
- More math methods, such as: `Repeat`, `PingPong`, `Map`, `Snap` and `SmoothStep`.
- An angle quantity.

## Limitations
Since exporting structs is currently not possible in the Godot game engine, the quantity structs cannot be edited in the inspector. As a work-around, you should export a `double` instead.
Should this feature become available in a future release, it will be added to this utility.

## Issues
The script were generated using [this generator repository](https://github.com/RustyRoboticsBV/Rusty.Quantities.Generator).

For any issues or feature proposals, please submit an issue on that repo.
