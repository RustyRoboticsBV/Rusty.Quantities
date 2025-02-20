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
- Comparison operators `==`, `!=`, `<`, `>`, `>=` and `<=`.
- Mathematical operators `+`, `-`, `*`, `/`, `%`, `++` and `--`.
- Convenience math methods, such as:
  - Numeric functions: `Abs`,  `Sign`, `Truncate`, `Frac` and `Dist`.
  - Advanced math operators: `Sqrt` and `Pow`.
  - Rounding methods: `Round`, `Floor` and `Ceil`.
  - Trigonimetric functions: `Sin`, `Cos` and `Tan`.
  - Stepping functions: `Step` and `Lerp`.
- Comparison operators.
- Formula methods, allowing for easy calculation of physics quantities from any combination of time, distance, (constant, start & end) speed and acceleration.

## Usage
Here's an example on how to use this module to find acceleration from some distance, time and start speed.

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

## Issues
The script were generated using [this repo](https://github.com/RustyRoboticsBV/Rusty.Quantities.Generator).

For any issues or feature proposals, please submit an issue on that repo.
