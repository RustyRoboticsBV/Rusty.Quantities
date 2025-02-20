using System;

namespace Rusty.Quantities
{
    /// <summary>
    /// A distance quantity.
    /// </summary>
    [Serializable]
    public readonly struct Distance : IScalarQuantity, IEquatable<Distance>, IComparable<Distance>
    {
        /* Fields. */
        /// <summary>
        /// The internal value of this distance quantity.
        /// </summary>
        private readonly double value;
        
        /* Public properties. */
        /// <summary>
        /// A distance object with the value 0.
        /// </summary>
        public static Distance Zero => new Distance(0.0);
        /// <summary>
        /// A distance object with the value 1.
        /// </summary>
        public static Distance One => new Distance(1.0);
        /// <summary>
        /// A distance object with the value π.
        /// </summary>
        public static Distance Pi => new Distance(Math.PI);
        /// <summary>
        /// A distance object with the value 2π.
        /// </summary>
        public static Distance TwoPi => new Distance(2.0 * Math.PI);
        
        /// <summary>
        /// The internal value of this distance quantity.
        /// </summary>
        public readonly double Value => value;
        
        /* Constructors. */
        /// <summary>
        /// Create a new distance quantity from another distance object.
        /// </summary>
        public Distance(Distance value)
        {
            this.value = value.value;
        }
        
        /// <summary>
        /// Create a new distance quantity from a scalar quantity object.
        /// </summary>
        public Distance(IScalarQuantity value)
        {
            this.value = value.Value;
        }
        
        /// <summary>
        /// Create a new distance quantity from a bool object.
        /// </summary>
        public Distance(bool value)
        {
            this.value = value ? 0.0 : 1.0;
        }
        
        /// <summary>
        /// Create a new distance quantity from an sbyte object.
        /// </summary>
        public Distance(sbyte value)
        {
            this.value = value;
        }
        
        /// <summary>
        /// Create a new distance quantity from a byte object.
        /// </summary>
        public Distance(byte value)
        {
            this.value = value;
        }
        
        /// <summary>
        /// Create a new distance quantity from a short object.
        /// </summary>
        public Distance(short value)
        {
            this.value = value;
        }
        
        /// <summary>
        /// Create a new distance quantity from an ushort object.
        /// </summary>
        public Distance(ushort value)
        {
            this.value = value;
        }
        
        /// <summary>
        /// Create a new distance quantity from an int object.
        /// </summary>
        public Distance(int value)
        {
            this.value = value;
        }
        
        /// <summary>
        /// Create a new distance quantity from an uint object.
        /// </summary>
        public Distance(uint value)
        {
            this.value = value;
        }
        
        /// <summary>
        /// Create a new distance quantity from a long object.
        /// </summary>
        public Distance(long value)
        {
            this.value = value;
        }
        
        /// <summary>
        /// Create a new distance quantity from an ulong object.
        /// </summary>
        public Distance(ulong value)
        {
            this.value = value;
        }
        
        /// <summary>
        /// Create a new distance quantity from a float object.
        /// </summary>
        public Distance(float value)
        {
            this.value = value;
        }
        
        /// <summary>
        /// Create a new distance quantity from a double object.
        /// </summary>
        public Distance(double value)
        {
            this.value = value;
        }
        
        /// <summary>
        /// Create a new distance quantity from a decimal object.
        /// </summary>
        public Distance(decimal value)
        {
            this.value = (double)value;
        }
        
        /// <summary>
        /// Create a new distance quantity from a char object.
        /// </summary>
        public Distance(char value)
        {
            this.value = value - '0';
        }
        
        /// <summary>
        /// Create a new distance quantity from a string object.
        /// </summary>
        public Distance(string value)
        {
            this.value = double.TryParse(value, out double result) ? result : 0.0;
        }
        
        /// <summary>
        /// Create a new distance quantity from a generic object. Results in the value 0 if the object cannot be converted.
        /// </summary>
        public Distance(object value)
        {
            switch (value)
            {
                case IScalarQuantity q:
                    this = new Distance(q);
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
            }
        }
        
        /* Casting operators. */
        /// <summary>
        /// Convert this distance quantity to a bool object.
        /// </summary>
        public static implicit operator bool(Distance value)
        {
            return value != Distance.Zero;
        }
        
        /// <summary>
        /// Convert this distance quantity to an sbyte object.
        /// </summary>
        public static implicit operator sbyte(Distance value)
        {
            return (sbyte)value.value;
        }
        
        /// <summary>
        /// Convert this distance quantity to a byte object.
        /// </summary>
        public static implicit operator byte(Distance value)
        {
            return (byte)value.value;
        }
        
        /// <summary>
        /// Convert this distance quantity to a short object.
        /// </summary>
        public static implicit operator short(Distance value)
        {
            return (short)value.value;
        }
        
        /// <summary>
        /// Convert this distance quantity to an ushort object.
        /// </summary>
        public static implicit operator ushort(Distance value)
        {
            return (ushort)value.value;
        }
        
        /// <summary>
        /// Convert this distance quantity to an int object.
        /// </summary>
        public static implicit operator int(Distance value)
        {
            return (int)value.value;
        }
        
        /// <summary>
        /// Convert this distance quantity to an uint object.
        /// </summary>
        public static implicit operator uint(Distance value)
        {
            return (uint)value.value;
        }
        
        /// <summary>
        /// Convert this distance quantity to a long object.
        /// </summary>
        public static implicit operator long(Distance value)
        {
            return (long)value.value;
        }
        
        /// <summary>
        /// Convert this distance quantity to an ulong object.
        /// </summary>
        public static implicit operator ulong(Distance value)
        {
            return (ulong)value.value;
        }
        
        /// <summary>
        /// Convert this distance quantity to a float object.
        /// </summary>
        public static implicit operator float(Distance value)
        {
            return (float)value.value;
        }
        
        /// <summary>
        /// Convert this distance quantity to a double object.
        /// </summary>
        public static implicit operator double(Distance value)
        {
            return value.value;
        }
        
        /// <summary>
        /// Convert this distance quantity to a decimal object.
        /// </summary>
        public static implicit operator decimal(Distance value)
        {
            return (decimal)value.value;
        }
        
        /// <summary>
        /// Convert this distance quantity to a char object.
        /// </summary>
        public static implicit operator char(Distance value)
        {
            return (char)(value.value + '0');
        }
        
        /// <summary>
        /// Convert this distance quantity to a string object.
        /// </summary>
        public static implicit operator string(Distance value)
        {
            return value.ToString();
        }
        
        /// <summary>
        /// Convert a bool object to a distance quantity.
        /// </summary>
        public static implicit operator Distance(bool value)
        {
            return new Distance(value);
        }
        
        /// <summary>
        /// Convert an sbyte object to a distance quantity.
        /// </summary>
        public static implicit operator Distance(sbyte value)
        {
            return new Distance(value);
        }
        
        /// <summary>
        /// Convert a byte object to a distance quantity.
        /// </summary>
        public static implicit operator Distance(byte value)
        {
            return new Distance(value);
        }
        
        /// <summary>
        /// Convert a short object to a distance quantity.
        /// </summary>
        public static implicit operator Distance(short value)
        {
            return new Distance(value);
        }
        
        /// <summary>
        /// Convert an ushort object to a distance quantity.
        /// </summary>
        public static implicit operator Distance(ushort value)
        {
            return new Distance(value);
        }
        
        /// <summary>
        /// Convert an int object to a distance quantity.
        /// </summary>
        public static implicit operator Distance(int value)
        {
            return new Distance(value);
        }
        
        /// <summary>
        /// Convert an uint object to a distance quantity.
        /// </summary>
        public static implicit operator Distance(uint value)
        {
            return new Distance(value);
        }
        
        /// <summary>
        /// Convert a long object to a distance quantity.
        /// </summary>
        public static implicit operator Distance(long value)
        {
            return new Distance(value);
        }
        
        /// <summary>
        /// Convert an ulong object to a distance quantity.
        /// </summary>
        public static implicit operator Distance(ulong value)
        {
            return new Distance(value);
        }
        
        /// <summary>
        /// Convert a float object to a distance quantity.
        /// </summary>
        public static implicit operator Distance(float value)
        {
            return new Distance(value);
        }
        
        /// <summary>
        /// Convert a double object to a distance quantity.
        /// </summary>
        public static implicit operator Distance(double value)
        {
            return new Distance(value);
        }
        
        /// <summary>
        /// Convert a decimal object to a distance quantity.
        /// </summary>
        public static implicit operator Distance(decimal value)
        {
            return new Distance(value);
        }
        
        /// <summary>
        /// Convert a char object to a distance quantity.
        /// </summary>
        public static implicit operator Distance(char value)
        {
            return new Distance(value);
        }
        
        /// <summary>
        /// Convert a string object to a distance quantity.
        /// </summary>
        public static implicit operator Distance(string value)
        {
            return new Distance(value);
        }
        
        /* Casting operators. */
        /// <summary>
        /// Check if a distance quantity is numerically equal to another one.
        /// </summary>
        public static bool operator ==(Distance a, Distance b)
        {
            return a.value == b.value;
        }
        
        /// <summary>
        /// Check if a distance quantity is NOT numerically equal to another one.
        /// </summary>
        public static bool operator !=(Distance a, Distance b)
        {
            return a.value != b.value;
        }
        
        /// <summary>
        /// Check if a distance quantity is numerically smaller than another one.
        /// </summary>
        public static bool operator <(Distance a, Distance b)
        {
            return a.value < b.value;
        }
        
        /// <summary>
        /// Check if a distance quantity is numerically greater than another one.
        /// </summary>
        public static bool operator >(Distance a, Distance b)
        {
            return a.value > b.value;
        }
        
        /// <summary>
        /// Check if a distance quantity is numerically smaller than or equal to another one.
        /// </summary>
        public static bool operator <=(Distance a, Distance b)
        {
            return a.value <= b.value;
        }
        
        /// <summary>
        /// Check if a distance quantity is numerically greater than or equal than another one.
        /// </summary>
        public static bool operator >=(Distance a, Distance b)
        {
            return a.value >= b.value;
        }
        
        /* Math operators. */
        /// <summary>
        /// Return the result of adding two distance quantities.
        /// </summary>
        public static Distance operator +(Distance a, Distance b)
        {
            return new Distance(a.value + b.value);
        }
        
        /// <summary>
        /// Return the result of subtracting a distance quantity from another.
        /// </summary>
        public static Distance operator -(Distance a, Distance b)
        {
            return new Distance(a.value - b.value);
        }
        
        /// <summary>
        /// Return the result of multiplying two distance quantities.
        /// </summary>
        public static Distance operator *(Distance a, Distance b)
        {
            return new Distance(a.value * b.value);
        }
        
        /// <summary>
        /// Return the result of dividing a distance quantity by another.
        /// </summary>
        public static Distance operator /(Distance a, Distance b)
        {
            return new Distance(a.value / b.value);
        }
        
        /// <summary>
        /// Return the remainder of dividing a distance quantity by another.
        /// </summary>
        public static Distance operator %(Distance a, Distance b)
        {
            return new Distance(a.value % b.value);
        }
        
        /// <summary>
        /// Return this distance quantity made negative.
        /// </summary>
        public static Distance operator -(Distance value)
        {
            return new Distance(-value.value);
        }
        
        /// <summary>
        /// Return this distance quantity incremented with 1.
        /// </summary>
        public static Distance operator ++(Distance value)
        {
            return new Distance(value.value + 1.0);
        }
        
        /// <summary>
        /// Return this distance quantity decremented with 1.
        /// </summary>
        public static Distance operator --(Distance value)
        {
            return new Distance(value.value - 1.0);
        }
        
        /* Public methods. */
        /// <summary>
        /// Convert this distance quantity to a string.
        /// </summary>
        public override readonly string ToString()
        {
            return value.ToString();
        }
        
        /// <summary>
        /// Check if this distance quantity is equal to another object.
        /// </summary>
        public override readonly bool Equals(object obj)
        {
            return obj is Distance value && Equals(value);
        }
        
        /// <summary>
        /// Check if this distance quantity is equal to another one.
        /// </summary>
        public readonly bool Equals(Distance value)
        {
            return this.value == value.value;
        }
        
        /// <summary>
        /// Get a hash code for this distance quantity.
        /// </summary>
        public override readonly int GetHashCode()
        {
            return value.GetHashCode();
        }
        
        /// <summary>
        /// Compare this distance quantity to another one. Returns -1 if it is smaller, 0 if it is equal, and 1 if it is larger.
        /// </summary>
        public readonly int CompareTo(Distance other)
        {
            if (this > other)
                return 1;
            else if (this < other)
                return -1;
            else
                return 0;
        }
        
        /// <summary>
        /// Return the absolute value of a distance quantity.
        /// </summary>
        public static Distance Abs(Distance value)
        {
            return value.Abs();
        }
        
        /// <summary>
        /// Return the absolute value of this distance quantity.
        /// </summary>
        public readonly Distance Abs()
        {
            return Math.Abs(value);
        }
        
        /// <summary>
        /// Return the mathematical sign of a distance quantity.
        /// </summary>
        public static int Sign(Distance value)
        {
            return value.Sign();
        }
        
        /// <summary>
        /// Return the mathematical sign of this distance quantity.
        /// </summary>
        public readonly int Sign()
        {
            return Math.Sign(value);
        }
        
        /// <summary>
        /// Return the integral part of a distance quantity.
        /// </summary>
        public static Distance Truncate(Distance value)
        {
            return value.Truncate();
        }
        
        /// <summary>
        /// Return the integral part of this distance quantity.
        /// </summary>
        public readonly Distance Truncate()
        {
            return Math.Truncate(value);
        }
        
        /// <summary>
        /// Return the fractional part of a distance quantity.
        /// </summary>
        public static Distance Frac(Distance value)
        {
            return value.Frac();
        }
        
        /// <summary>
        /// Return the fractional part of this distance quantity.
        /// </summary>
        public readonly Distance Frac()
        {
            return new Distance(((decimal)value) % 1m);
        }
        
        /// <summary>
        /// Return the distance between two distance quantities.
        /// </summary>
        public static Distance Dist(Distance a, Distance b)
        {
            return a.Dist(b);
        }
        
        /// <summary>
        /// Return the distance between this distance quantity and another one.
        /// </summary>
        public readonly Distance Dist(Distance other)
        {
            return new Distance(this > other ? this - other : other - this);
        }
        
        /// <summary>
        /// Return the result of raising a distance quantity to some exponent.
        /// </summary>
        public static Distance Pow(Distance value, Distance exponent)
        {
            return value.Pow(exponent);
        }
        
        /// <summary>
        /// Return the result of raising this distance quantity to some exponent.
        /// </summary>
        public readonly Distance Pow(Distance exponent)
        {
            return Math.Pow(value, exponent);
        }
        
        /// <summary>
        /// Return the square root of a distance quantity.
        /// </summary>
        public static Distance Sqrt(Distance value)
        {
            return value.Sqrt();
        }
        
        /// <summary>
        /// Return the square root of this distance quantity.
        /// </summary>
        public readonly Distance Sqrt()
        {
            return Math.Sqrt(value);
        }
        
        /// <summary>
        /// Return the smallest of two distance quantities.
        /// </summary>
        public static Distance Min(Distance a, Distance b)
        {
            return a.Min(b);
        }
        
        /// <summary>
        /// Compare this distance quantity to another one and return the smallest one.
        /// </summary>
        public readonly Distance Min(Distance other)
        {
            return Math.Min(value, other.value);
        }
        
        /// <summary>
        /// Return the largest of two distance quantities.
        /// </summary>
        public static Distance Max(Distance a, Distance b)
        {
            return a.Max(b);
        }
        
        /// <summary>
        /// Compare this distance quantity to another one and return the largest one.
        /// </summary>
        public readonly Distance Max(Distance other)
        {
            return Math.Max(value, other.value);
        }
        
        /// <summary>
        /// Force a distance quantity into some numerical range.
        /// </summary>
        public static Distance Clamp(Distance value, Distance min, Distance max)
        {
            return value.Clamp(min, max);
        }
        
        /// <summary>
        /// Force this distance quantity into some numerical range.
        /// </summary>
        public readonly Distance Clamp(Distance min, Distance max)
        {
            if (value < min)
                return min;
            else if (value > max)
                return max;
            else
                return value;
        }
        
        /// <summary>
        /// Round a distance quantity and return the result.
        /// </summary>
        public static Distance Round(Distance value)
        {
            return value.Round();
        }
        
        /// <summary>
        /// Round this distance quantity and return the result.
        /// </summary>
        public readonly Distance Round()
        {
            return Math.Round(value);
        }
        
        /// <summary>
        /// Round a distance quantity down to the nearest integer and return the result.
        /// </summary>
        public static Distance Floor(Distance value)
        {
            return value.Floor();
        }
        
        /// <summary>
        /// Round this distance quantity down to the nearest integer and return the result.
        /// </summary>
        public readonly Distance Floor()
        {
            return Math.Floor(value);
        }
        
        /// <summary>
        /// Round a distance quantity up to the nearest integer and return the result.
        /// </summary>
        public static Distance Ceil(Distance value)
        {
            return value.Ceil();
        }
        
        /// <summary>
        /// Round this distance quantity up to the nearest integer and return the result.
        /// </summary>
        public readonly Distance Ceil()
        {
            return Math.Ceiling(value);
        }
        
        /// <summary>
        /// Return the sine of a distance quantity.
        /// </summary>
        public static Distance Sin(Distance value)
        {
            return value.Sin();
        }
        
        /// <summary>
        /// Return the sine of this distance quantity.
        /// </summary>
        public readonly Distance Sin()
        {
            return Math.Sin(value);
        }
        
        /// <summary>
        /// Return the cosine of a distance quantity.
        /// </summary>
        public static Distance Cos(Distance value)
        {
            return value.Cos();
        }
        
        /// <summary>
        /// Return the cosine of this distance quantity.
        /// </summary>
        public readonly Distance Cos()
        {
            return Math.Cos(value);
        }
        
        /// <summary>
        /// Return the tangent of a distance quantity.
        /// </summary>
        public static Distance Tan(Distance value)
        {
            return value.Tan();
        }
        
        /// <summary>
        /// Return the tangent of this distance quantity.
        /// </summary>
        public readonly Distance Tan()
        {
            return Math.Tan(value);
        }
        
        /// <summary>
        /// Return the result of stepping a distance quantity towards a target value, using some step size.
        /// </summary>
        public static Distance Step(Distance from, Distance to, Distance stepSize)
        {
            return from.Step(to, stepSize);
        }
        
        /// <summary>
        /// Return the result of stepping this distance quantity towards a target value, using some step size.
        /// </summary>
        public readonly Distance Step(Distance target, Distance stepSize)
        {
            if (this < target)
                return Min(this + stepSize.Abs(), target);
            else if (this > target)
                return Max(this - stepSize.Abs(), target);
            else
                return target;
        }
        
        /// <summary>
        /// Return the result of linearly-interpolating between two distance quantities, using some interpolation factor between 0 and 1.
        /// </summary>
        public static Distance Lerp(Distance a, Distance b, double factor)
        {
            return a + (b - a) * Math.Min(Math.Max(factor, 0.0), 1.0);
        }
        
        /// <summary>
        /// Calculate distance from constant speed and time.
        /// </summary>
        public static Distance FromVT(Speed constantSpeed, Time time)
        {
            return (double)constantSpeed * (double)time;
        }
        
        /// <summary>
        /// Calculate distance from start speed, end speed and time.
        /// </summary>
        public static Distance FromUVT(Speed startSpeed, Speed endSpeed, Time time)
        {
            return 1 / 2 * ((double)endSpeed + (double)startSpeed) * (double)time;
        }
        
        /// <summary>
        /// Calculate distance from start speed, end speed and acceleration.
        /// </summary>
        public static Distance FromUVA(Speed startSpeed, Speed endSpeed, Acceleration acceleration)
        {
            return (Pow2((double)endSpeed) - Pow2((double)startSpeed)) / (2 * (double)acceleration);
        }
        
        /// <summary>
        /// Calculate distance from start speed, acceleration and time.
        /// </summary>
        public static Distance FromUAT(Speed startSpeed, Acceleration acceleration, Time time)
        {
            return (double)startSpeed * (double)time + 1 / 2 * (double)acceleration * Pow2((double)time);
        }
        
        /// <summary>
        /// Calculate distance from end speed, acceleration and time.
        /// </summary>
        public static Distance FromVAT(Speed endSpeed, Acceleration acceleration, Time time)
        {
            return (double)endSpeed * (double)time - 1 / 2 * (double)acceleration * Pow2((double)time);
        }
        
        /* Private methods. */
        private static Distance Pow2(double value)
        {
            return value * value;
        }
    }
}