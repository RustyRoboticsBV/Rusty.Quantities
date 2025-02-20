# Rusty.Quantities
A C# library of physics quantities. It provides various structs that represent common physics quantities, complete with various method to calculate them from each other. You can use them to do things like figuring out how far an accelerating object will move over some time, or calculating a jump's start speed from its height and gravity.

It was intended for custom character controllers in the [Godot game engine](https://github.com/godotengine/godot), but can be used in any C# application.

## Features
### Quantities
The following quantities are supported:
- Time
- Distance
- Speed
- Acceleration

### Struct Contents
All structs are based on the `double` type. They contain various properties, methods and operators.
- Implicit conversion operators to and from the following types: `bool`, `sbyte`, `byte`, `short`, `ushort`, `int`, `uint`, `long`, `ulong`, `float`, `double`, `decimal`, `char` and `string`.

- Mathematical operators: `+`, `-`, `*`, `/`, `%`, `++` and `--`.

- Comparison operators: `==`, `!=`, `<`, `>`, `>=` and `<=`.

- Physics formula methods, allowing for easy calculation of physics quantities from any valid combination of time, distance, speed (constant, start or end) and acceleration.

- Convenience math methods, such as:
  - Numeric functions: `Abs`,  `Sign`, `Truncate`, `Frac` and `Dist`.
  - Advanced math operators: `Sqrt` and `Pow`.
  - Rounding methods: `Round`, `Floor` and `Ceil`.
  - Trigonometric functions: `Sin`, `Cos` and `Tan`.
  - Interpolation functions: `Step` and `Lerp`.

- Constant properties: `Zero`, `One`, `Pi` and `TwoPi`.

## Usage
As an example: here's how you would calculate the start speed of a jump, from the jump height and gravity.

    using Rusty.Quantities;
    
    public class Character
    {
        public Speed CalcJumpStartSpeed(Distance jumpHeight, Acceleration gravity)
        {
            return Speed.StartSpeedFromSVA(jumpHeight, 0, gravity);
        }
    }
   
For further details: all structs and their members have been documented with a short summary.

## Planned Features
- More math methods, such as: `Repeat`, `PingPong`, `Map`, `Snap` and `SmoothStep`.
- An angle quantity.
- Conversion to game engine types, while preserving engine agnosticism.

## Limitations
Since exporting structs is currently not possible in the Godot game engine, the quantity structs cannot be edited in the inspector. As a work-around, you should export a `double` instead.

Should this feature become available in a future release, it will be added to this utility.

## Issues
The scripts were generated using [this generator repository](https://github.com/RustyRoboticsBV/Rusty.Quantities.Generator).

For any issues or feature proposals, please submit an issue on that repo.
