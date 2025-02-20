using System;

namespace Rusty.Quantities
{
    /// <summary>
    /// An acceleration quantity.
    /// </summary>
    [Serializable]
    public readonly struct Acceleration : IScalarQuantity, IEquatable<Acceleration>, IComparable<Acceleration>
    {
        /* Fields. */
        /// <summary>
        /// The internal value of this acceleration quantity.
        /// </summary>
        private readonly double value;
        
        /* Public properties. */
        /// <summary>
        /// A acceleration object with the value 0.
        /// </summary>
        public static Acceleration Zero => new Acceleration(0.0);
        /// <summary>
        /// A acceleration object with the value 1.
        /// </summary>
        public static Acceleration One => new Acceleration(1.0);
        /// <summary>
        /// A acceleration object with the value π.
        /// </summary>
        public static Acceleration Pi => new Acceleration(Math.PI);
        /// <summary>
        /// A acceleration object with the value 2π.
        /// </summary>
        public static Acceleration TwoPi => new Acceleration(2.0 * Math.PI);
        
        /// <summary>
        /// The internal value of this acceleration quantity.
        /// </summary>
        public readonly double Value => value;
        
        /* Constructors. */
        /// <summary>
        /// Create a new acceleration quantity from another acceleration object.
        /// </summary>
        public Acceleration(Acceleration value)
        {
            this.value = value.value;
        }
        
        /// <summary>
        /// Create a new acceleration quantity from a scalar quantity object.
        /// </summary>
        public Acceleration(IScalarQuantity value)
        {
            this.value = value.Value;
        }
        
        /// <summary>
        /// Create a new acceleration quantity from a bool object.
        /// </summary>
        public Acceleration(bool value)
        {
            this.value = value ? 0.0 : 1.0;
        }
        
        /// <summary>
        /// Create a new acceleration quantity from an sbyte object.
        /// </summary>
        public Acceleration(sbyte value)
        {
            this.value = value;
        }
        
        /// <summary>
        /// Create a new acceleration quantity from a byte object.
        /// </summary>
        public Acceleration(byte value)
        {
            this.value = value;
        }
        
        /// <summary>
        /// Create a new acceleration quantity from a short object.
        /// </summary>
        public Acceleration(short value)
        {
            this.value = value;
        }
        
        /// <summary>
        /// Create a new acceleration quantity from an ushort object.
        /// </summary>
        public Acceleration(ushort value)
        {
            this.value = value;
        }
        
        /// <summary>
        /// Create a new acceleration quantity from an int object.
        /// </summary>
        public Acceleration(int value)
        {
            this.value = value;
        }
        
        /// <summary>
        /// Create a new acceleration quantity from an uint object.
        /// </summary>
        public Acceleration(uint value)
        {
            this.value = value;
        }
        
        /// <summary>
        /// Create a new acceleration quantity from a long object.
        /// </summary>
        public Acceleration(long value)
        {
            this.value = value;
        }
        
        /// <summary>
        /// Create a new acceleration quantity from an ulong object.
        /// </summary>
        public Acceleration(ulong value)
        {
            this.value = value;
        }
        
        /// <summary>
        /// Create a new acceleration quantity from a float object.
        /// </summary>
        public Acceleration(float value)
        {
            this.value = value;
        }
        
        /// <summary>
        /// Create a new acceleration quantity from a double object.
        /// </summary>
        public Acceleration(double value)
        {
            this.value = value;
        }
        
        /// <summary>
        /// Create a new acceleration quantity from a decimal object.
        /// </summary>
        public Acceleration(decimal value)
        {
            this.value = (double)value;
        }
        
        /// <summary>
        /// Create a new acceleration quantity from a char object.
        /// </summary>
        public Acceleration(char value)
        {
            this.value = value - '0';
        }
        
        /// <summary>
        /// Create a new acceleration quantity from a string object.
        /// </summary>
        public Acceleration(string value)
        {
            this.value = double.TryParse(value, out double result) ? result : 0.0;
        }
        
        /// <summary>
        /// Create a new acceleration quantity from a generic object. Results in the value 0 if the object cannot be converted.
        /// </summary>
        public Acceleration(object value)
        {
            switch (value)
            {
                case IScalarQuantity q:
                    this = new Acceleration(q);
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
                    this = new Acceleration(0.0);
                    break;
            }
        }
        
        /* Casting operators. */
        /// <summary>
        /// Convert this acceleration quantity to a bool object.
        /// </summary>
        public static implicit operator bool(Acceleration value)
        {
            return value != Acceleration.Zero;
        }
        
        /// <summary>
        /// Convert this acceleration quantity to an sbyte object.
        /// </summary>
        public static implicit operator sbyte(Acceleration value)
        {
            return (sbyte)value.value;
        }
        
        /// <summary>
        /// Convert this acceleration quantity to a byte object.
        /// </summary>
        public static implicit operator byte(Acceleration value)
        {
            return (byte)value.value;
        }
        
        /// <summary>
        /// Convert this acceleration quantity to a short object.
        /// </summary>
        public static implicit operator short(Acceleration value)
        {
            return (short)value.value;
        }
        
        /// <summary>
        /// Convert this acceleration quantity to an ushort object.
        /// </summary>
        public static implicit operator ushort(Acceleration value)
        {
            return (ushort)value.value;
        }
        
        /// <summary>
        /// Convert this acceleration quantity to an int object.
        /// </summary>
        public static implicit operator int(Acceleration value)
        {
            return (int)value.value;
        }
        
        /// <summary>
        /// Convert this acceleration quantity to an uint object.
        /// </summary>
        public static implicit operator uint(Acceleration value)
        {
            return (uint)value.value;
        }
        
        /// <summary>
        /// Convert this acceleration quantity to a long object.
        /// </summary>
        public static implicit operator long(Acceleration value)
        {
            return (long)value.value;
        }
        
        /// <summary>
        /// Convert this acceleration quantity to an ulong object.
        /// </summary>
        public static implicit operator ulong(Acceleration value)
        {
            return (ulong)value.value;
        }
        
        /// <summary>
        /// Convert this acceleration quantity to a float object.
        /// </summary>
        public static implicit operator float(Acceleration value)
        {
            return (float)value.value;
        }
        
        /// <summary>
        /// Convert this acceleration quantity to a double object.
        /// </summary>
        public static implicit operator double(Acceleration value)
        {
            return value.value;
        }
        
        /// <summary>
        /// Convert this acceleration quantity to a decimal object.
        /// </summary>
        public static implicit operator decimal(Acceleration value)
        {
            return (decimal)value.value;
        }
        
        /// <summary>
        /// Convert this acceleration quantity to a char object.
        /// </summary>
        public static implicit operator char(Acceleration value)
        {
            return (char)(value.value + '0');
        }
        
        /// <summary>
        /// Convert this acceleration quantity to a string object.
        /// </summary>
        public static implicit operator string(Acceleration value)
        {
            return value.ToString();
        }
        
        /// <summary>
        /// Convert a bool object to a acceleration quantity.
        /// </summary>
        public static implicit operator Acceleration(bool value)
        {
            return new Acceleration(value);
        }
        
        /// <summary>
        /// Convert an sbyte object to a acceleration quantity.
        /// </summary>
        public static implicit operator Acceleration(sbyte value)
        {
            return new Acceleration(value);
        }
        
        /// <summary>
        /// Convert a byte object to a acceleration quantity.
        /// </summary>
        public static implicit operator Acceleration(byte value)
        {
            return new Acceleration(value);
        }
        
        /// <summary>
        /// Convert a short object to a acceleration quantity.
        /// </summary>
        public static implicit operator Acceleration(short value)
        {
            return new Acceleration(value);
        }
        
        /// <summary>
        /// Convert an ushort object to a acceleration quantity.
        /// </summary>
        public static implicit operator Acceleration(ushort value)
        {
            return new Acceleration(value);
        }
        
        /// <summary>
        /// Convert an int object to a acceleration quantity.
        /// </summary>
        public static implicit operator Acceleration(int value)
        {
            return new Acceleration(value);
        }
        
        /// <summary>
        /// Convert an uint object to a acceleration quantity.
        /// </summary>
        public static implicit operator Acceleration(uint value)
        {
            return new Acceleration(value);
        }
        
        /// <summary>
        /// Convert a long object to a acceleration quantity.
        /// </summary>
        public static implicit operator Acceleration(long value)
        {
            return new Acceleration(value);
        }
        
        /// <summary>
        /// Convert an ulong object to a acceleration quantity.
        /// </summary>
        public static implicit operator Acceleration(ulong value)
        {
            return new Acceleration(value);
        }
        
        /// <summary>
        /// Convert a float object to a acceleration quantity.
        /// </summary>
        public static implicit operator Acceleration(float value)
        {
            return new Acceleration(value);
        }
        
        /// <summary>
        /// Convert a double object to a acceleration quantity.
        /// </summary>
        public static implicit operator Acceleration(double value)
        {
            return new Acceleration(value);
        }
        
        /// <summary>
        /// Convert a decimal object to a acceleration quantity.
        /// </summary>
        public static implicit operator Acceleration(decimal value)
        {
            return new Acceleration(value);
        }
        
        /// <summary>
        /// Convert a char object to a acceleration quantity.
        /// </summary>
        public static implicit operator Acceleration(char value)
        {
            return new Acceleration(value);
        }
        
        /// <summary>
        /// Convert a string object to a acceleration quantity.
        /// </summary>
        public static implicit operator Acceleration(string value)
        {
            return new Acceleration(value);
        }
        
        /* Casting operators. */
        /// <summary>
        /// Check if an acceleration quantity is numerically equal to another one.
        /// </summary>
        public static bool operator ==(Acceleration a, Acceleration b)
        {
            return a.value == b.value;
        }
        
        /// <summary>
        /// Check if an acceleration quantity is NOT numerically equal to another one.
        /// </summary>
        public static bool operator !=(Acceleration a, Acceleration b)
        {
            return a.value != b.value;
        }
        
        /// <summary>
        /// Check if an acceleration quantity is numerically smaller than another one.
        /// </summary>
        public static bool operator <(Acceleration a, Acceleration b)
        {
            return a.value < b.value;
        }
        
        /// <summary>
        /// Check if an acceleration quantity is numerically greater than another one.
        /// </summary>
        public static bool operator >(Acceleration a, Acceleration b)
        {
            return a.value > b.value;
        }
        
        /// <summary>
        /// Check if an acceleration quantity is numerically smaller than or equal to another one.
        /// </summary>
        public static bool operator <=(Acceleration a, Acceleration b)
        {
            return a.value <= b.value;
        }
        
        /// <summary>
        /// Check if an acceleration quantity is numerically greater than or equal than another one.
        /// </summary>
        public static bool operator >=(Acceleration a, Acceleration b)
        {
            return a.value >= b.value;
        }
        
        /* Math operators. */
        /// <summary>
        /// Return the result of adding two acceleration quantities.
        /// </summary>
        public static Acceleration operator +(Acceleration a, Acceleration b)
        {
            return new Acceleration(a.value + b.value);
        }
        
        /// <summary>
        /// Return the result of subtracting an acceleration quantity from another.
        /// </summary>
        public static Acceleration operator -(Acceleration a, Acceleration b)
        {
            return new Acceleration(a.value - b.value);
        }
        
        /// <summary>
        /// Return the result of multiplying two acceleration quantities.
        /// </summary>
        public static Acceleration operator *(Acceleration a, Acceleration b)
        {
            return new Acceleration(a.value * b.value);
        }
        
        /// <summary>
        /// Return the result of dividing an acceleration quantity by another.
        /// </summary>
        public static Acceleration operator /(Acceleration a, Acceleration b)
        {
            return new Acceleration(a.value / b.value);
        }
        
        /// <summary>
        /// Return the remainder of dividing an acceleration quantity by another.
        /// </summary>
        public static Acceleration operator %(Acceleration a, Acceleration b)
        {
            return new Acceleration(a.value % b.value);
        }
        
        /// <summary>
        /// Return this acceleration quantity made negative.
        /// </summary>
        public static Acceleration operator -(Acceleration value)
        {
            return new Acceleration(-value.value);
        }
        
        /// <summary>
        /// Return this acceleration quantity incremented with 1.
        /// </summary>
        public static Acceleration operator ++(Acceleration value)
        {
            return new Acceleration(value.value + 1.0);
        }
        
        /// <summary>
        /// Return this acceleration quantity decremented with 1.
        /// </summary>
        public static Acceleration operator --(Acceleration value)
        {
            return new Acceleration(value.value - 1.0);
        }
        
        /* Public methods. */
        /// <summary>
        /// Convert this acceleration quantity to a string.
        /// </summary>
        public override readonly string ToString()
        {
            return value.ToString();
        }
        
        /// <summary>
        /// Check if this acceleration quantity is equal to another object.
        /// </summary>
        public override readonly bool Equals(object obj)
        {
            return obj is Acceleration value && Equals(value);
        }
        
        /// <summary>
        /// Check if this acceleration quantity is equal to another one.
        /// </summary>
        public readonly bool Equals(Acceleration value)
        {
            return this.value == value.value;
        }
        
        /// <summary>
        /// Get a hash code for this acceleration quantity.
        /// </summary>
        public override readonly int GetHashCode()
        {
            return value.GetHashCode();
        }
        
        /// <summary>
        /// Compare this acceleration quantity to another one. Returns -1 if it is smaller, 0 if it is equal, and 1 if it is larger.
        /// </summary>
        public readonly int CompareTo(Acceleration other)
        {
            if (this > other)
                return 1;
            else if (this < other)
                return -1;
            else
                return 0;
        }
        
        /// <summary>
        /// Return the absolute value of an acceleration quantity.
        /// </summary>
        public static Acceleration Abs(Acceleration value)
        {
            return value.Abs();
        }
        
        /// <summary>
        /// Return the absolute value of this acceleration quantity.
        /// </summary>
        public readonly Acceleration Abs()
        {
            return Math.Abs(value);
        }
        
        /// <summary>
        /// Return the mathematical sign of an acceleration quantity.
        /// </summary>
        public static int Sign(Acceleration value)
        {
            return value.Sign();
        }
        
        /// <summary>
        /// Return the mathematical sign of this acceleration quantity.
        /// </summary>
        public readonly int Sign()
        {
            return Math.Sign(value);
        }
        
        /// <summary>
        /// Return the integral part of an acceleration quantity.
        /// </summary>
        public static Acceleration Truncate(Acceleration value)
        {
            return value.Truncate();
        }
        
        /// <summary>
        /// Return the integral part of this acceleration quantity.
        /// </summary>
        public readonly Acceleration Truncate()
        {
            return Math.Truncate(value);
        }
        
        /// <summary>
        /// Return the fractional part of an acceleration quantity.
        /// </summary>
        public static Acceleration Frac(Acceleration value)
        {
            return value.Frac();
        }
        
        /// <summary>
        /// Return the fractional part of this acceleration quantity.
        /// </summary>
        public readonly Acceleration Frac()
        {
            return new Acceleration(((decimal)value) % 1m);
        }
        
        /// <summary>
        /// Return the distance between two acceleration quantities.
        /// </summary>
        public static Acceleration Dist(Acceleration a, Acceleration b)
        {
            return a.Dist(b);
        }
        
        /// <summary>
        /// Return the distance between this acceleration quantity and another one.
        /// </summary>
        public readonly Acceleration Dist(Acceleration other)
        {
            return new Acceleration(this > other ? this - other : other - this);
        }
        
        /// <summary>
        /// Return the result of raising an acceleration quantity to some exponent.
        /// </summary>
        public static Acceleration Pow(Acceleration value, Acceleration exponent)
        {
            return value.Pow(exponent);
        }
        
        /// <summary>
        /// Return the result of raising this acceleration quantity to some exponent.
        /// </summary>
        public readonly Acceleration Pow(Acceleration exponent)
        {
            return Math.Pow(value, exponent);
        }
        
        /// <summary>
        /// Return the square root of an acceleration quantity.
        /// </summary>
        public static Acceleration Sqrt(Acceleration value)
        {
            return value.Sqrt();
        }
        
        /// <summary>
        /// Return the square root of this acceleration quantity.
        /// </summary>
        public readonly Acceleration Sqrt()
        {
            return Math.Sqrt(value);
        }
        
        /// <summary>
        /// Return the smallest of two acceleration quantities.
        /// </summary>
        public static Acceleration Min(Acceleration a, Acceleration b)
        {
            return a.Min(b);
        }
        
        /// <summary>
        /// Compare this acceleration quantity to another one and return the smallest one.
        /// </summary>
        public readonly Acceleration Min(Acceleration other)
        {
            return Math.Min(value, other.value);
        }
        
        /// <summary>
        /// Return the largest of two acceleration quantities.
        /// </summary>
        public static Acceleration Max(Acceleration a, Acceleration b)
        {
            return a.Max(b);
        }
        
        /// <summary>
        /// Compare this acceleration quantity to another one and return the largest one.
        /// </summary>
        public readonly Acceleration Max(Acceleration other)
        {
            return Math.Max(value, other.value);
        }
        
        /// <summary>
        /// Force a acceleration quantity into some numerical range.
        /// </summary>
        public static Acceleration Clamp(Acceleration value, Acceleration min, Acceleration max)
        {
            return value.Clamp(min, max);
        }
        
        /// <summary>
        /// Force this acceleration quantity into some numerical range.
        /// </summary>
        public readonly Acceleration Clamp(Acceleration min, Acceleration max)
        {
            if (value < min)
                return min;
            else if (value > max)
                return max;
            else
                return value;
        }
        
        /// <summary>
        /// Round an acceleration quantity and return the result.
        /// </summary>
        public static Acceleration Round(Acceleration value)
        {
            return value.Round();
        }
        
        /// <summary>
        /// Round this acceleration quantity and return the result.
        /// </summary>
        public readonly Acceleration Round()
        {
            return Math.Round(value);
        }
        
        /// <summary>
        /// Round an acceleration quantity down to the nearest integer and return the result.
        /// </summary>
        public static Acceleration Floor(Acceleration value)
        {
            return value.Floor();
        }
        
        /// <summary>
        /// Round this acceleration quantity down to the nearest integer and return the result.
        /// </summary>
        public readonly Acceleration Floor()
        {
            return Math.Floor(value);
        }
        
        /// <summary>
        /// Round an acceleration quantity up to the nearest integer and return the result.
        /// </summary>
        public static Acceleration Ceil(Acceleration value)
        {
            return value.Ceil();
        }
        
        /// <summary>
        /// Round this acceleration quantity up to the nearest integer and return the result.
        /// </summary>
        public readonly Acceleration Ceil()
        {
            return Math.Ceiling(value);
        }
        
        /// <summary>
        /// Return the sine of an acceleration quantity.
        /// </summary>
        public static Acceleration Sin(Acceleration value)
        {
            return value.Sin();
        }
        
        /// <summary>
        /// Return the sine of this acceleration quantity.
        /// </summary>
        public readonly Acceleration Sin()
        {
            return Math.Sin(value);
        }
        
        /// <summary>
        /// Return the cosine of an acceleration quantity.
        /// </summary>
        public static Acceleration Cos(Acceleration value)
        {
            return value.Cos();
        }
        
        /// <summary>
        /// Return the cosine of this acceleration quantity.
        /// </summary>
        public readonly Acceleration Cos()
        {
            return Math.Cos(value);
        }
        
        /// <summary>
        /// Return the tangent of an acceleration quantity.
        /// </summary>
        public static Acceleration Tan(Acceleration value)
        {
            return value.Tan();
        }
        
        /// <summary>
        /// Return the tangent of this acceleration quantity.
        /// </summary>
        public readonly Acceleration Tan()
        {
            return Math.Tan(value);
        }
        
        /// <summary>
        /// Return the result of stepping an acceleration quantity towards a target value, using some step size.
        /// </summary>
        public static Acceleration Step(Acceleration from, Acceleration to, Acceleration stepSize)
        {
            return from.Step(to, stepSize);
        }
        
        /// <summary>
        /// Return the result of stepping this acceleration quantity towards a target value, using some step size.
        /// </summary>
        public readonly Acceleration Step(Acceleration target, Acceleration stepSize)
        {
            if (this < target)
                return Min(this + stepSize.Abs(), target);
            else if (this > target)
                return Max(this - stepSize.Abs(), target);
            else
                return target;
        }
        
        /// <summary>
        /// Return the result of linearly-interpolating between two acceleration quantities, using some interpolation factor between 0 and 1.
        /// </summary>
        public static Acceleration Lerp(Acceleration a, Acceleration b, double factor)
        {
            return a + (b - a) * Math.Min(Math.Max(factor, 0.0), 1.0);
        }
        
        /// <summary>
        /// Calculate acceleration from start speed, end speed and time.
        /// </summary>
        public static Acceleration FromUVT(Speed startSpeed, Speed endSpeed, Time time)
        {
            return ((double)endSpeed - (double)startSpeed) / (double)time;
        }
        
        /// <summary>
        /// Calculate acceleration from distance, start speed and end speed.
        /// </summary>
        public static Acceleration FromSUV(Distance distance, Speed startSpeed, Speed endSpeed)
        {
            return (Pow2((double)endSpeed) - Pow2((double)startSpeed)) / (2 * (double)distance);
        }
        
        /// <summary>
        /// Calculate acceleration from distance, start speed and time.
        /// </summary>
        public static Acceleration FromSUT(Distance distance, Speed startSpeed, Time time)
        {
            return 2 * (double)distance / Pow2((double)time) - 2 * (double)startSpeed / (double)time;
        }
        
        /// <summary>
        /// Calculate acceleration from distance, end speed and time.
        /// </summary>
        public static Acceleration FromSVT(Distance distance, Speed endSpeed, Time time)
        {
            return -2 * ((double)distance - (double)endSpeed * (double)time) / Pow2((double)time);
        }
        
        /* Private methods. */
        private static Acceleration Pow2(double value)
        {
            return value * value;
        }
    }
}