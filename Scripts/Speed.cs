using System;

namespace Rusty.Quantities
{
    /// <summary>
    /// A speed quantity.
    /// </summary>
    [Serializable]
    public readonly struct Speed : IScalarQuantity, IEquatable<Speed>, IComparable<Speed>
    {
        /* Fields. */
        /// <summary>
        /// The internal value of this speed quantity.
        /// </summary>
        private readonly double value;
        
        /* Public properties. */
        /// <summary>
        /// A speed object with the value 0.
        /// </summary>
        public static Speed Zero => new Speed(0.0);
        /// <summary>
        /// A speed object with the value 1.
        /// </summary>
        public static Speed One => new Speed(1.0);
        /// <summary>
        /// A speed object with the value π.
        /// </summary>
        public static Speed Pi => new Speed(Math.PI);
        /// <summary>
        /// A speed object with the value 2π.
        /// </summary>
        public static Speed TwoPi => new Speed(2.0 * Math.PI);
        
        /// <summary>
        /// The internal value of this speed quantity.
        /// </summary>
        public readonly double Value => value;
        
        /* Constructors. */
        /// <summary>
        /// Create a new speed quantity from another speed object.
        /// </summary>
        public Speed(Speed value)
        {
            this.value = value.value;
        }
        
        /// <summary>
        /// Create a new speed quantity from a scalar quantity object.
        /// </summary>
        public Speed(IScalarQuantity value)
        {
            this.value = value.Value;
        }
        
        /// <summary>
        /// Create a new speed quantity from a bool object.
        /// </summary>
        public Speed(bool value)
        {
            this.value = value ? 0.0 : 1.0;
        }
        
        /// <summary>
        /// Create a new speed quantity from an sbyte object.
        /// </summary>
        public Speed(sbyte value)
        {
            this.value = value;
        }
        
        /// <summary>
        /// Create a new speed quantity from a byte object.
        /// </summary>
        public Speed(byte value)
        {
            this.value = value;
        }
        
        /// <summary>
        /// Create a new speed quantity from a short object.
        /// </summary>
        public Speed(short value)
        {
            this.value = value;
        }
        
        /// <summary>
        /// Create a new speed quantity from an ushort object.
        /// </summary>
        public Speed(ushort value)
        {
            this.value = value;
        }
        
        /// <summary>
        /// Create a new speed quantity from an int object.
        /// </summary>
        public Speed(int value)
        {
            this.value = value;
        }
        
        /// <summary>
        /// Create a new speed quantity from an uint object.
        /// </summary>
        public Speed(uint value)
        {
            this.value = value;
        }
        
        /// <summary>
        /// Create a new speed quantity from a long object.
        /// </summary>
        public Speed(long value)
        {
            this.value = value;
        }
        
        /// <summary>
        /// Create a new speed quantity from an ulong object.
        /// </summary>
        public Speed(ulong value)
        {
            this.value = value;
        }
        
        /// <summary>
        /// Create a new speed quantity from a float object.
        /// </summary>
        public Speed(float value)
        {
            this.value = value;
        }
        
        /// <summary>
        /// Create a new speed quantity from a double object.
        /// </summary>
        public Speed(double value)
        {
            this.value = value;
        }
        
        /// <summary>
        /// Create a new speed quantity from a decimal object.
        /// </summary>
        public Speed(decimal value)
        {
            this.value = (double)value;
        }
        
        /// <summary>
        /// Create a new speed quantity from a char object.
        /// </summary>
        public Speed(char value)
        {
            this.value = value - '0';
        }
        
        /// <summary>
        /// Create a new speed quantity from a string object.
        /// </summary>
        public Speed(string value)
        {
            this.value = double.TryParse(value, out double result) ? result : 0.0;
        }
        
        /// <summary>
        /// Create a new speed quantity from a generic object. Results in the value 0 if the object cannot be converted.
        /// </summary>
        public Speed(object value)
        {
            switch (value)
            {
                case IScalarQuantity q:
                    this = new Speed(q);
                    break;
                case bool b:
                    this = b;
                    break;
                case sbyte i8:
                    this = i8;
                    break;
                case short i16:
                    this = i16;
                    break;
                case int i32:
                    this = i32;
                    break;
                case long i64:
                    this = i64;
                    break;
                case byte u8:
                    this = u8;
                    break;
                case ushort u16:
                    this = u16;
                    break;
                case uint u32:
                    this = u32;
                    break;
                case ulong u64:
                    this = u64;
                    break;
                case float f32:
                    this = f32;
                    break;
                case double f64:
                    this = f64;
                    break;
                case decimal f128:
                    this = f128;
                    break;
                case char c:
                    this = c;
                    break;
                case string s:
                    this = s;
                    break;
                default:
                    this = new Speed(0.0);
                    break;
            }
        }
        
        /* Casting operators. */
        /// <summary>
        /// Convert this speed quantity to a bool object.
        /// </summary>
        public static implicit operator bool(Speed value)
        {
            return value != Speed.Zero;
        }
        
        /// <summary>
        /// Convert this speed quantity to an sbyte object.
        /// </summary>
        public static implicit operator sbyte(Speed value)
        {
            return (sbyte)value.value;
        }
        
        /// <summary>
        /// Convert this speed quantity to a byte object.
        /// </summary>
        public static implicit operator byte(Speed value)
        {
            return (byte)value.value;
        }
        
        /// <summary>
        /// Convert this speed quantity to a short object.
        /// </summary>
        public static implicit operator short(Speed value)
        {
            return (short)value.value;
        }
        
        /// <summary>
        /// Convert this speed quantity to an ushort object.
        /// </summary>
        public static implicit operator ushort(Speed value)
        {
            return (ushort)value.value;
        }
        
        /// <summary>
        /// Convert this speed quantity to an int object.
        /// </summary>
        public static implicit operator int(Speed value)
        {
            return (int)value.value;
        }
        
        /// <summary>
        /// Convert this speed quantity to an uint object.
        /// </summary>
        public static implicit operator uint(Speed value)
        {
            return (uint)value.value;
        }
        
        /// <summary>
        /// Convert this speed quantity to a long object.
        /// </summary>
        public static implicit operator long(Speed value)
        {
            return (long)value.value;
        }
        
        /// <summary>
        /// Convert this speed quantity to an ulong object.
        /// </summary>
        public static implicit operator ulong(Speed value)
        {
            return (ulong)value.value;
        }
        
        /// <summary>
        /// Convert this speed quantity to a float object.
        /// </summary>
        public static implicit operator float(Speed value)
        {
            return (float)value.value;
        }
        
        /// <summary>
        /// Convert this speed quantity to a double object.
        /// </summary>
        public static implicit operator double(Speed value)
        {
            return value.value;
        }
        
        /// <summary>
        /// Convert this speed quantity to a decimal object.
        /// </summary>
        public static implicit operator decimal(Speed value)
        {
            return (decimal)value.value;
        }
        
        /// <summary>
        /// Convert this speed quantity to a char object.
        /// </summary>
        public static implicit operator char(Speed value)
        {
            return (char)(value.value + '0');
        }
        
        /// <summary>
        /// Convert this speed quantity to a string object.
        /// </summary>
        public static implicit operator string(Speed value)
        {
            return value.ToString();
        }
        
        /// <summary>
        /// Convert a bool object to a speed quantity.
        /// </summary>
        public static implicit operator Speed(bool value)
        {
            return new Speed(value);
        }
        
        /// <summary>
        /// Convert an sbyte object to a speed quantity.
        /// </summary>
        public static implicit operator Speed(sbyte value)
        {
            return new Speed(value);
        }
        
        /// <summary>
        /// Convert a byte object to a speed quantity.
        /// </summary>
        public static implicit operator Speed(byte value)
        {
            return new Speed(value);
        }
        
        /// <summary>
        /// Convert a short object to a speed quantity.
        /// </summary>
        public static implicit operator Speed(short value)
        {
            return new Speed(value);
        }
        
        /// <summary>
        /// Convert an ushort object to a speed quantity.
        /// </summary>
        public static implicit operator Speed(ushort value)
        {
            return new Speed(value);
        }
        
        /// <summary>
        /// Convert an int object to a speed quantity.
        /// </summary>
        public static implicit operator Speed(int value)
        {
            return new Speed(value);
        }
        
        /// <summary>
        /// Convert an uint object to a speed quantity.
        /// </summary>
        public static implicit operator Speed(uint value)
        {
            return new Speed(value);
        }
        
        /// <summary>
        /// Convert a long object to a speed quantity.
        /// </summary>
        public static implicit operator Speed(long value)
        {
            return new Speed(value);
        }
        
        /// <summary>
        /// Convert an ulong object to a speed quantity.
        /// </summary>
        public static implicit operator Speed(ulong value)
        {
            return new Speed(value);
        }
        
        /// <summary>
        /// Convert a float object to a speed quantity.
        /// </summary>
        public static implicit operator Speed(float value)
        {
            return new Speed(value);
        }
        
        /// <summary>
        /// Convert a double object to a speed quantity.
        /// </summary>
        public static implicit operator Speed(double value)
        {
            return new Speed(value);
        }
        
        /// <summary>
        /// Convert a decimal object to a speed quantity.
        /// </summary>
        public static implicit operator Speed(decimal value)
        {
            return new Speed(value);
        }
        
        /// <summary>
        /// Convert a char object to a speed quantity.
        /// </summary>
        public static implicit operator Speed(char value)
        {
            return new Speed(value);
        }
        
        /// <summary>
        /// Convert a string object to a speed quantity.
        /// </summary>
        public static implicit operator Speed(string value)
        {
            return new Speed(value);
        }
        
        /* Casting operators. */
        /// <summary>
        /// Check if a speed quantity is numerically equal to another one.
        /// </summary>
        public static bool operator ==(Speed a, Speed b)
        {
            return a.value == b.value;
        }
        
        /// <summary>
        /// Check if a speed quantity is NOT numerically equal to another one.
        /// </summary>
        public static bool operator !=(Speed a, Speed b)
        {
            return a.value != b.value;
        }
        
        /// <summary>
        /// Check if a speed quantity is numerically smaller than another one.
        /// </summary>
        public static bool operator <(Speed a, Speed b)
        {
            return a.value < b.value;
        }
        
        /// <summary>
        /// Check if a speed quantity is numerically greater than another one.
        /// </summary>
        public static bool operator >(Speed a, Speed b)
        {
            return a.value > b.value;
        }
        
        /// <summary>
        /// Check if a speed quantity is numerically smaller than or equal to another one.
        /// </summary>
        public static bool operator <=(Speed a, Speed b)
        {
            return a.value <= b.value;
        }
        
        /// <summary>
        /// Check if a speed quantity is numerically greater than or equal than another one.
        /// </summary>
        public static bool operator >=(Speed a, Speed b)
        {
            return a.value >= b.value;
        }
        
        /* Math operators. */
        /// <summary>
        /// Return the result of adding two speed quantities.
        /// </summary>
        public static Speed operator +(Speed a, Speed b)
        {
            return new Speed(a.value + b.value);
        }
        
        /// <summary>
        /// Return the result of subtracting a speed quantity from another.
        /// </summary>
        public static Speed operator -(Speed a, Speed b)
        {
            return new Speed(a.value - b.value);
        }
        
        /// <summary>
        /// Return the result of multiplying two speed quantities.
        /// </summary>
        public static Speed operator *(Speed a, Speed b)
        {
            return new Speed(a.value * b.value);
        }
        
        /// <summary>
        /// Return the result of dividing a speed quantity by another.
        /// </summary>
        public static Speed operator /(Speed a, Speed b)
        {
            return new Speed(a.value / b.value);
        }
        
        /// <summary>
        /// Return the remainder of dividing a speed quantity by another.
        /// </summary>
        public static Speed operator %(Speed a, Speed b)
        {
            return new Speed(a.value % b.value);
        }
        
        /// <summary>
        /// Return this speed quantity made negative.
        /// </summary>
        public static Speed operator -(Speed value)
        {
            return new Speed(-value.value);
        }
        
        /// <summary>
        /// Return this speed quantity incremented with 1.
        /// </summary>
        public static Speed operator ++(Speed value)
        {
            return new Speed(value.value + 1.0);
        }
        
        /// <summary>
        /// Return this speed quantity decremented with 1.
        /// </summary>
        public static Speed operator --(Speed value)
        {
            return new Speed(value.value - 1.0);
        }
        
        /* Public methods. */
        /// <summary>
        /// Convert this speed quantity to a string.
        /// </summary>
        public override readonly string ToString()
        {
            return value.ToString();
        }
        
        /// <summary>
        /// Check if this speed quantity is equal to another object.
        /// </summary>
        public override readonly bool Equals(object obj)
        {
            return obj is Speed value && Equals(value);
        }
        
        /// <summary>
        /// Check if this speed quantity is equal to another one.
        /// </summary>
        public readonly bool Equals(Speed value)
        {
            return this.value == value.value;
        }
        
        /// <summary>
        /// Get a hash code for this speed quantity.
        /// </summary>
        public override readonly int GetHashCode()
        {
            return value.GetHashCode();
        }
        
        /// <summary>
        /// Compare this speed quantity to another one. Returns -1 if it is smaller, 0 if it is equal, and 1 if it is larger.
        /// </summary>
        public readonly int CompareTo(Speed other)
        {
            if (this > other)
                return 1;
            else if (this < other)
                return -1;
            else
                return 0;
        }
        
        /// <summary>
        /// Return the absolute value of a speed quantity.
        /// </summary>
        public static Speed Abs(Speed value)
        {
            return value.Abs();
        }
        
        /// <summary>
        /// Return the absolute value of this speed quantity.
        /// </summary>
        public readonly Speed Abs()
        {
            return Math.Abs(value);
        }
        
        /// <summary>
        /// Return the mathematical sign of a speed quantity.
        /// </summary>
        public static int Sign(Speed value)
        {
            return value.Sign();
        }
        
        /// <summary>
        /// Return the mathematical sign of this speed quantity.
        /// </summary>
        public readonly int Sign()
        {
            return Math.Sign(value);
        }
        
        /// <summary>
        /// Return the integral part of a speed quantity.
        /// </summary>
        public static Speed Truncate(Speed value)
        {
            return value.Truncate();
        }
        
        /// <summary>
        /// Return the integral part of this speed quantity.
        /// </summary>
        public readonly Speed Truncate()
        {
            return Math.Truncate(value);
        }
        
        /// <summary>
        /// Return the fractional part of a speed quantity.
        /// </summary>
        public static Speed Frac(Speed value)
        {
            return value.Frac();
        }
        
        /// <summary>
        /// Return the fractional part of this speed quantity.
        /// </summary>
        public readonly Speed Frac()
        {
            return new Speed(((decimal)value) % 1m);
        }
        
        /// <summary>
        /// Return the distance between two speed quantities.
        /// </summary>
        public static Speed Dist(Speed a, Speed b)
        {
            return a.Dist(b);
        }
        
        /// <summary>
        /// Return the distance between this speed quantity and another one.
        /// </summary>
        public readonly Speed Dist(Speed other)
        {
            return new Speed(this > other ? this - other : other - this);
        }
        
        /// <summary>
        /// Return the result of raising a speed quantity to some exponent.
        /// </summary>
        public static Speed Pow(Speed value, Speed exponent)
        {
            return value.Pow(exponent);
        }
        
        /// <summary>
        /// Return the result of raising this speed quantity to some exponent.
        /// </summary>
        public readonly Speed Pow(Speed exponent)
        {
            return Math.Pow(value, exponent);
        }
        
        /// <summary>
        /// Return the square root of a speed quantity.
        /// </summary>
        public static Speed Sqrt(Speed value)
        {
            return value.Sqrt();
        }
        
        /// <summary>
        /// Return the square root of this speed quantity.
        /// </summary>
        public readonly Speed Sqrt()
        {
            return Math.Sqrt(value);
        }
        
        /// <summary>
        /// Return the smallest of two speed quantities.
        /// </summary>
        public static Speed Min(Speed a, Speed b)
        {
            return a.Min(b);
        }
        
        /// <summary>
        /// Compare this speed quantity to another one and return the smallest one.
        /// </summary>
        public readonly Speed Min(Speed other)
        {
            return Math.Min(value, other.value);
        }
        
        /// <summary>
        /// Return the largest of two speed quantities.
        /// </summary>
        public static Speed Max(Speed a, Speed b)
        {
            return a.Max(b);
        }
        
        /// <summary>
        /// Compare this speed quantity to another one and return the largest one.
        /// </summary>
        public readonly Speed Max(Speed other)
        {
            return Math.Max(value, other.value);
        }
        
        /// <summary>
        /// Force a speed quantity into some numerical range.
        /// </summary>
        public static Speed Clamp(Speed value, Speed min, Speed max)
        {
            return value.Clamp(min, max);
        }
        
        /// <summary>
        /// Force this speed quantity into some numerical range.
        /// </summary>
        public readonly Speed Clamp(Speed min, Speed max)
        {
            if (value < min)
                return min;
            else if (value > max)
                return max;
            else
                return value;
        }
        
        /// <summary>
        /// Round a speed quantity and return the result.
        /// </summary>
        public static Speed Round(Speed value)
        {
            return value.Round();
        }
        
        /// <summary>
        /// Round this speed quantity and return the result.
        /// </summary>
        public readonly Speed Round()
        {
            return Math.Round(value);
        }
        
        /// <summary>
        /// Round a speed quantity down to the nearest integer and return the result.
        /// </summary>
        public static Speed Floor(Speed value)
        {
            return value.Floor();
        }
        
        /// <summary>
        /// Round this speed quantity down to the nearest integer and return the result.
        /// </summary>
        public readonly Speed Floor()
        {
            return Math.Floor(value);
        }
        
        /// <summary>
        /// Round a speed quantity up to the nearest integer and return the result.
        /// </summary>
        public static Speed Ceil(Speed value)
        {
            return value.Ceil();
        }
        
        /// <summary>
        /// Round this speed quantity up to the nearest integer and return the result.
        /// </summary>
        public readonly Speed Ceil()
        {
            return Math.Ceiling(value);
        }
        
        /// <summary>
        /// Return the sine of a speed quantity.
        /// </summary>
        public static Speed Sin(Speed value)
        {
            return value.Sin();
        }
        
        /// <summary>
        /// Return the sine of this speed quantity.
        /// </summary>
        public readonly Speed Sin()
        {
            return Math.Sin(value);
        }
        
        /// <summary>
        /// Return the cosine of a speed quantity.
        /// </summary>
        public static Speed Cos(Speed value)
        {
            return value.Cos();
        }
        
        /// <summary>
        /// Return the cosine of this speed quantity.
        /// </summary>
        public readonly Speed Cos()
        {
            return Math.Cos(value);
        }
        
        /// <summary>
        /// Return the tangent of a speed quantity.
        /// </summary>
        public static Speed Tan(Speed value)
        {
            return value.Tan();
        }
        
        /// <summary>
        /// Return the tangent of this speed quantity.
        /// </summary>
        public readonly Speed Tan()
        {
            return Math.Tan(value);
        }
        
        /// <summary>
        /// Return the result of stepping a speed quantity towards a target value, using some step size.
        /// </summary>
        public static Speed Step(Speed from, Speed to, Speed stepSize)
        {
            return from.Step(to, stepSize);
        }
        
        /// <summary>
        /// Return the result of stepping this speed quantity towards a target value, using some step size.
        /// </summary>
        public readonly Speed Step(Speed target, Speed stepSize)
        {
            if (this < target)
                return Min(this + stepSize.Abs(), target);
            else if (this > target)
                return Max(this - stepSize.Abs(), target);
            else
                return target;
        }
        
        /// <summary>
        /// Return the result of linearly-interpolating between two speed quantities, using some interpolation factor between 0 and 1.
        /// </summary>
        public static Speed Lerp(Speed a, Speed b, double factor)
        {
            return a + (b - a) * Math.Min(Math.Max(factor, 0.0), 1.0);
        }
        
        /// <summary>
        /// Calculate constant speed from distance and time.
        /// </summary>
        public static Speed ConstSpeedFromST(Distance distance, Time time)
        {
            return (double)distance / (double)time;
        }
        
        /// <summary>
        /// Calculate end speed from distance, start speed and time.
        /// </summary>
        public static Speed EndSpeedFromSUT(Distance distance, Speed startSpeed, Time time)
        {
            return 2 * (double)distance / (double)time - startSpeed.value;
        }
        
        /// <summary>
        /// Calculate start speed from distance, end speed and time.
        /// </summary>
        public static Speed StartSpeedFromSVT(Distance distance, Speed endSpeed, Time time)
        {
            return 2 * (double)distance / (double)time - endSpeed.value;
        }
        
        /// <summary>
        /// Calculate end speed from start speed, acceleration and time.
        /// </summary>
        public static Speed EndSpeedFromUAT(Speed startSpeed, Acceleration acceleration, Time time)
        {
            return startSpeed.value + (double)acceleration * (double)time;
        }
        
        /// <summary>
        /// Calculate start speed from end speed, acceleration and time.
        /// </summary>
        public static Speed StartSpeedFromVAT(Speed endSpeed, Acceleration acceleration, Time time)
        {
            return endSpeed.value - (double)acceleration * (double)time;
        }
        
        /// <summary>
        /// Calculate end speed from distance, start speed and acceleration.
        /// </summary>
        public static Speed EndSpeedFromSUA(Distance distance, Speed startSpeed, Acceleration acceleration)
        {
            return Sqrt(Pow2(startSpeed.value) + 2 * (double)acceleration * (double)distance);
        }
        
        /// <summary>
        /// Calculate start speed from distance, end speed and acceleration.
        /// </summary>
        public static Speed StartSpeedFromSVA(Distance distance, Speed endSpeed, Acceleration acceleration)
        {
            return Sqrt(Pow2(endSpeed.value) - 2 * (double)acceleration * (double)distance);
        }
        
        /// <summary>
        /// Calculate start speed from distance, acceleration and time.
        /// </summary>
        public static Speed StartSpeedFromSAT(Distance distance, Acceleration acceleration, Time time)
        {
            return (double)distance / (double)time - 0.5 / 2 * (double)acceleration * (double)time;
        }
        
        /// <summary>
        /// Calculate end speed from distance, acceleration and time.
        /// </summary>
        public static Speed EndSpeedFromSAT(Distance distance, Acceleration acceleration, Time time)
        {
            return (double)distance / (double)time + 0.5 / 2 * (double)acceleration * (double)time;
        }
        
        /* Private methods. */
        private static Speed Pow2(double value)
        {
            return value * value;
        }
    }
}