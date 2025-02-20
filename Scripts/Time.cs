using System;

namespace Rusty.Quantities
{
    /// <summary>
    /// A time quantity.
    /// </summary>
    [Serializable]
    public readonly struct Time : IScalarQuantity, IEquatable<Time>, IComparable<Time>
    {
        /* Fields. */
        /// <summary>
        /// The internal value of this time quantity.
        /// </summary>
        private readonly double value;
        
        /* Public properties. */
        /// <summary>
        /// A time object with the value 0.
        /// </summary>
        public static Time Zero => new Time(0.0);
        /// <summary>
        /// A time object with the value 1.
        /// </summary>
        public static Time One => new Time(1.0);
        /// <summary>
        /// A time object with the value π.
        /// </summary>
        public static Time Pi => new Time(Math.PI);
        /// <summary>
        /// A time object with the value 2π.
        /// </summary>
        public static Time TwoPi => new Time(2.0 * Math.PI);
        
        /// <summary>
        /// The internal value of this time quantity.
        /// </summary>
        public readonly double Value => value;
        
        /* Constructors. */
        /// <summary>
        /// Create a new time quantity from another time object.
        /// </summary>
        public Time(Time value)
        {
            this.value = value.value;
        }
        
        /// <summary>
        /// Create a new time quantity from a scalar quantity object.
        /// </summary>
        public Time(IScalarQuantity value)
        {
            this.value = value.Value;
        }
        
        /// <summary>
        /// Create a new time quantity from a bool object.
        /// </summary>
        public Time(bool value)
        {
            this.value = value ? 0.0 : 1.0;
        }
        
        /// <summary>
        /// Create a new time quantity from an sbyte object.
        /// </summary>
        public Time(sbyte value)
        {
            this.value = value;
        }
        
        /// <summary>
        /// Create a new time quantity from a byte object.
        /// </summary>
        public Time(byte value)
        {
            this.value = value;
        }
        
        /// <summary>
        /// Create a new time quantity from a short object.
        /// </summary>
        public Time(short value)
        {
            this.value = value;
        }
        
        /// <summary>
        /// Create a new time quantity from an ushort object.
        /// </summary>
        public Time(ushort value)
        {
            this.value = value;
        }
        
        /// <summary>
        /// Create a new time quantity from an int object.
        /// </summary>
        public Time(int value)
        {
            this.value = value;
        }
        
        /// <summary>
        /// Create a new time quantity from an uint object.
        /// </summary>
        public Time(uint value)
        {
            this.value = value;
        }
        
        /// <summary>
        /// Create a new time quantity from a long object.
        /// </summary>
        public Time(long value)
        {
            this.value = value;
        }
        
        /// <summary>
        /// Create a new time quantity from an ulong object.
        /// </summary>
        public Time(ulong value)
        {
            this.value = value;
        }
        
        /// <summary>
        /// Create a new time quantity from a float object.
        /// </summary>
        public Time(float value)
        {
            this.value = value;
        }
        
        /// <summary>
        /// Create a new time quantity from a double object.
        /// </summary>
        public Time(double value)
        {
            this.value = value;
        }
        
        /// <summary>
        /// Create a new time quantity from a decimal object.
        /// </summary>
        public Time(decimal value)
        {
            this.value = (double)value;
        }
        
        /// <summary>
        /// Create a new time quantity from a char object.
        /// </summary>
        public Time(char value)
        {
            this.value = value - '0';
        }
        
        /// <summary>
        /// Create a new time quantity from a string object.
        /// </summary>
        public Time(string value)
        {
            this.value = double.TryParse(value, out double result) ? result : 0.0;
        }
        
        /// <summary>
        /// Create a new time quantity from a generic object. Results in the value 0 if the object cannot be converted.
        /// </summary>
        public Time(object value)
        {
            switch (value)
            {
                case IScalarQuantity q:
                    this = new Time(q);
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
        /// Convert this time quantity to a bool object.
        /// </summary>
        public static implicit operator bool(Time value)
        {
            return value != Time.Zero;
        }
        
        /// <summary>
        /// Convert this time quantity to an sbyte object.
        /// </summary>
        public static implicit operator sbyte(Time value)
        {
            return (sbyte)value.value;
        }
        
        /// <summary>
        /// Convert this time quantity to a byte object.
        /// </summary>
        public static implicit operator byte(Time value)
        {
            return (byte)value.value;
        }
        
        /// <summary>
        /// Convert this time quantity to a short object.
        /// </summary>
        public static implicit operator short(Time value)
        {
            return (short)value.value;
        }
        
        /// <summary>
        /// Convert this time quantity to an ushort object.
        /// </summary>
        public static implicit operator ushort(Time value)
        {
            return (ushort)value.value;
        }
        
        /// <summary>
        /// Convert this time quantity to an int object.
        /// </summary>
        public static implicit operator int(Time value)
        {
            return (int)value.value;
        }
        
        /// <summary>
        /// Convert this time quantity to an uint object.
        /// </summary>
        public static implicit operator uint(Time value)
        {
            return (uint)value.value;
        }
        
        /// <summary>
        /// Convert this time quantity to a long object.
        /// </summary>
        public static implicit operator long(Time value)
        {
            return (long)value.value;
        }
        
        /// <summary>
        /// Convert this time quantity to an ulong object.
        /// </summary>
        public static implicit operator ulong(Time value)
        {
            return (ulong)value.value;
        }
        
        /// <summary>
        /// Convert this time quantity to a float object.
        /// </summary>
        public static implicit operator float(Time value)
        {
            return (float)value.value;
        }
        
        /// <summary>
        /// Convert this time quantity to a double object.
        /// </summary>
        public static implicit operator double(Time value)
        {
            return value.value;
        }
        
        /// <summary>
        /// Convert this time quantity to a decimal object.
        /// </summary>
        public static implicit operator decimal(Time value)
        {
            return (decimal)value.value;
        }
        
        /// <summary>
        /// Convert this time quantity to a char object.
        /// </summary>
        public static implicit operator char(Time value)
        {
            return (char)(value.value + '0');
        }
        
        /// <summary>
        /// Convert this time quantity to a string object.
        /// </summary>
        public static implicit operator string(Time value)
        {
            return value.ToString();
        }
        
        /// <summary>
        /// Convert a bool object to a time quantity.
        /// </summary>
        public static implicit operator Time(bool value)
        {
            return new Time(value);
        }
        
        /// <summary>
        /// Convert an sbyte object to a time quantity.
        /// </summary>
        public static implicit operator Time(sbyte value)
        {
            return new Time(value);
        }
        
        /// <summary>
        /// Convert a byte object to a time quantity.
        /// </summary>
        public static implicit operator Time(byte value)
        {
            return new Time(value);
        }
        
        /// <summary>
        /// Convert a short object to a time quantity.
        /// </summary>
        public static implicit operator Time(short value)
        {
            return new Time(value);
        }
        
        /// <summary>
        /// Convert an ushort object to a time quantity.
        /// </summary>
        public static implicit operator Time(ushort value)
        {
            return new Time(value);
        }
        
        /// <summary>
        /// Convert an int object to a time quantity.
        /// </summary>
        public static implicit operator Time(int value)
        {
            return new Time(value);
        }
        
        /// <summary>
        /// Convert an uint object to a time quantity.
        /// </summary>
        public static implicit operator Time(uint value)
        {
            return new Time(value);
        }
        
        /// <summary>
        /// Convert a long object to a time quantity.
        /// </summary>
        public static implicit operator Time(long value)
        {
            return new Time(value);
        }
        
        /// <summary>
        /// Convert an ulong object to a time quantity.
        /// </summary>
        public static implicit operator Time(ulong value)
        {
            return new Time(value);
        }
        
        /// <summary>
        /// Convert a float object to a time quantity.
        /// </summary>
        public static implicit operator Time(float value)
        {
            return new Time(value);
        }
        
        /// <summary>
        /// Convert a double object to a time quantity.
        /// </summary>
        public static implicit operator Time(double value)
        {
            return new Time(value);
        }
        
        /// <summary>
        /// Convert a decimal object to a time quantity.
        /// </summary>
        public static implicit operator Time(decimal value)
        {
            return new Time(value);
        }
        
        /// <summary>
        /// Convert a char object to a time quantity.
        /// </summary>
        public static implicit operator Time(char value)
        {
            return new Time(value);
        }
        
        /// <summary>
        /// Convert a string object to a time quantity.
        /// </summary>
        public static implicit operator Time(string value)
        {
            return new Time(value);
        }
        
        /* Casting operators. */
        /// <summary>
        /// Check if a time quantity is numerically equal to another one.
        /// </summary>
        public static bool operator ==(Time a, Time b)
        {
            return a.value == b.value;
        }
        
        /// <summary>
        /// Check if a time quantity is NOT numerically equal to another one.
        /// </summary>
        public static bool operator !=(Time a, Time b)
        {
            return a.value != b.value;
        }
        
        /// <summary>
        /// Check if a time quantity is numerically smaller than another one.
        /// </summary>
        public static bool operator <(Time a, Time b)
        {
            return a.value < b.value;
        }
        
        /// <summary>
        /// Check if a time quantity is numerically greater than another one.
        /// </summary>
        public static bool operator >(Time a, Time b)
        {
            return a.value > b.value;
        }
        
        /// <summary>
        /// Check if a time quantity is numerically smaller than or equal to another one.
        /// </summary>
        public static bool operator <=(Time a, Time b)
        {
            return a.value <= b.value;
        }
        
        /// <summary>
        /// Check if a time quantity is numerically greater than or equal than another one.
        /// </summary>
        public static bool operator >=(Time a, Time b)
        {
            return a.value >= b.value;
        }
        
        /* Math operators. */
        /// <summary>
        /// Return the result of adding two time quantities.
        /// </summary>
        public static Time operator +(Time a, Time b)
        {
            return new Time(a.value + b.value);
        }
        
        /// <summary>
        /// Return the result of subtracting a time quantity from another.
        /// </summary>
        public static Time operator -(Time a, Time b)
        {
            return new Time(a.value - b.value);
        }
        
        /// <summary>
        /// Return the result of multiplying two time quantities.
        /// </summary>
        public static Time operator *(Time a, Time b)
        {
            return new Time(a.value * b.value);
        }
        
        /// <summary>
        /// Return the result of dividing a time quantity by another.
        /// </summary>
        public static Time operator /(Time a, Time b)
        {
            return new Time(a.value / b.value);
        }
        
        /// <summary>
        /// Return the remainder of dividing a time quantity by another.
        /// </summary>
        public static Time operator %(Time a, Time b)
        {
            return new Time(a.value % b.value);
        }
        
        /// <summary>
        /// Return this time quantity made negative.
        /// </summary>
        public static Time operator -(Time value)
        {
            return new Time(-value.value);
        }
        
        /// <summary>
        /// Return this time quantity incremented with 1.
        /// </summary>
        public static Time operator ++(Time value)
        {
            return new Time(value.value + 1.0);
        }
        
        /// <summary>
        /// Return this time quantity decremented with 1.
        /// </summary>
        public static Time operator --(Time value)
        {
            return new Time(value.value - 1.0);
        }
        
        /* Public methods. */
        /// <summary>
        /// Convert this time quantity to a string.
        /// </summary>
        public override readonly string ToString()
        {
            return value.ToString();
        }
        
        /// <summary>
        /// Check if this time quantity is equal to another object.
        /// </summary>
        public override readonly bool Equals(object obj)
        {
            return obj is Time value && Equals(value);
        }
        
        /// <summary>
        /// Check if this time quantity is equal to another one.
        /// </summary>
        public readonly bool Equals(Time value)
        {
            return this.value == value.value;
        }
        
        /// <summary>
        /// Get a hash code for this time quantity.
        /// </summary>
        public override readonly int GetHashCode()
        {
            return value.GetHashCode();
        }
        
        /// <summary>
        /// Compare this time quantity to another one. Returns -1 if it is smaller, 0 if it is equal, and 1 if it is larger.
        /// </summary>
        public readonly int CompareTo(Time other)
        {
            if (this > other)
                return 1;
            else if (this < other)
                return -1;
            else
                return 0;
        }
        
        /// <summary>
        /// Return the absolute value of a time quantity.
        /// </summary>
        public static Time Abs(Time value)
        {
            return value.Abs();
        }
        
        /// <summary>
        /// Return the absolute value of this time quantity.
        /// </summary>
        public readonly Time Abs()
        {
            return Math.Abs(value);
        }
        
        /// <summary>
        /// Return the mathematical sign of a time quantity.
        /// </summary>
        public static int Sign(Time value)
        {
            return value.Sign();
        }
        
        /// <summary>
        /// Return the mathematical sign of this time quantity.
        /// </summary>
        public readonly int Sign()
        {
            return Math.Sign(value);
        }
        
        /// <summary>
        /// Return the integral part of a time quantity.
        /// </summary>
        public static Time Truncate(Time value)
        {
            return value.Truncate();
        }
        
        /// <summary>
        /// Return the integral part of this time quantity.
        /// </summary>
        public readonly Time Truncate()
        {
            return Math.Truncate(value);
        }
        
        /// <summary>
        /// Return the fractional part of a time quantity.
        /// </summary>
        public static Time Frac(Time value)
        {
            return value.Frac();
        }
        
        /// <summary>
        /// Return the fractional part of this time quantity.
        /// </summary>
        public readonly Time Frac()
        {
            return new Time(((decimal)value) % 1m);
        }
        
        /// <summary>
        /// Return the distance between two time quantities.
        /// </summary>
        public static Time Dist(Time a, Time b)
        {
            return a.Dist(b);
        }
        
        /// <summary>
        /// Return the distance between this time quantity and another one.
        /// </summary>
        public readonly Time Dist(Time other)
        {
            return new Time(this > other ? this - other : other - this);
        }
        
        /// <summary>
        /// Return the result of raising a time quantity to some exponent.
        /// </summary>
        public static Time Pow(Time value, Time exponent)
        {
            return value.Pow(exponent);
        }
        
        /// <summary>
        /// Return the result of raising this time quantity to some exponent.
        /// </summary>
        public readonly Time Pow(Time exponent)
        {
            return Math.Pow(value, exponent);
        }
        
        /// <summary>
        /// Return the square root of a time quantity.
        /// </summary>
        public static Time Sqrt(Time value)
        {
            return value.Sqrt();
        }
        
        /// <summary>
        /// Return the square root of this time quantity.
        /// </summary>
        public readonly Time Sqrt()
        {
            return Math.Sqrt(value);
        }
        
        /// <summary>
        /// Return the smallest of two time quantities.
        /// </summary>
        public static Time Min(Time a, Time b)
        {
            return a.Min(b);
        }
        
        /// <summary>
        /// Compare this time quantity to another one and return the smallest one.
        /// </summary>
        public readonly Time Min(Time other)
        {
            return Math.Min(value, other.value);
        }
        
        /// <summary>
        /// Return the largest of two time quantities.
        /// </summary>
        public static Time Max(Time a, Time b)
        {
            return a.Max(b);
        }
        
        /// <summary>
        /// Compare this time quantity to another one and return the largest one.
        /// </summary>
        public readonly Time Max(Time other)
        {
            return Math.Max(value, other.value);
        }
        
        /// <summary>
        /// Force a time quantity into some numerical range.
        /// </summary>
        public static Time Clamp(Time value, Time min, Time max)
        {
            return value.Clamp(min, max);
        }
        
        /// <summary>
        /// Force this time quantity into some numerical range.
        /// </summary>
        public readonly Time Clamp(Time min, Time max)
        {
            if (value < min)
                return min;
            else if (value > max)
                return max;
            else
                return value;
        }
        
        /// <summary>
        /// Round a time quantity and return the result.
        /// </summary>
        public static Time Round(Time value)
        {
            return value.Round();
        }
        
        /// <summary>
        /// Round this time quantity and return the result.
        /// </summary>
        public readonly Time Round()
        {
            return Math.Round(value);
        }
        
        /// <summary>
        /// Round a time quantity down to the nearest integer and return the result.
        /// </summary>
        public static Time Floor(Time value)
        {
            return value.Floor();
        }
        
        /// <summary>
        /// Round this time quantity down to the nearest integer and return the result.
        /// </summary>
        public readonly Time Floor()
        {
            return Math.Floor(value);
        }
        
        /// <summary>
        /// Round a time quantity up to the nearest integer and return the result.
        /// </summary>
        public static Time Ceil(Time value)
        {
            return value.Ceil();
        }
        
        /// <summary>
        /// Round this time quantity up to the nearest integer and return the result.
        /// </summary>
        public readonly Time Ceil()
        {
            return Math.Ceiling(value);
        }
        
        /// <summary>
        /// Return the sine of a time quantity.
        /// </summary>
        public static Time Sin(Time value)
        {
            return value.Sin();
        }
        
        /// <summary>
        /// Return the sine of this time quantity.
        /// </summary>
        public readonly Time Sin()
        {
            return Math.Sin(value);
        }
        
        /// <summary>
        /// Return the cosine of a time quantity.
        /// </summary>
        public static Time Cos(Time value)
        {
            return value.Cos();
        }
        
        /// <summary>
        /// Return the cosine of this time quantity.
        /// </summary>
        public readonly Time Cos()
        {
            return Math.Cos(value);
        }
        
        /// <summary>
        /// Return the tangent of a time quantity.
        /// </summary>
        public static Time Tan(Time value)
        {
            return value.Tan();
        }
        
        /// <summary>
        /// Return the tangent of this time quantity.
        /// </summary>
        public readonly Time Tan()
        {
            return Math.Tan(value);
        }
        
        /// <summary>
        /// Return the result of stepping a time quantity towards a target value, using some step size.
        /// </summary>
        public static Time Step(Time from, Time to, Time stepSize)
        {
            return from.Step(to, stepSize);
        }
        
        /// <summary>
        /// Return the result of stepping this time quantity towards a target value, using some step size.
        /// </summary>
        public readonly Time Step(Time target, Time stepSize)
        {
            if (this < target)
                return Min(this + stepSize.Abs(), target);
            else if (this > target)
                return Max(this - stepSize.Abs(), target);
            else
                return target;
        }
        
        /// <summary>
        /// Return the result of linearly-interpolating between two time quantities, using some interpolation factor between 0 and 1.
        /// </summary>
        public static Time Lerp(Time a, Time b, double factor)
        {
            return a + (b - a) * Math.Min(Math.Max(factor, 0.0), 1.0);
        }
        
        /// <summary>
        /// Calculate time from distance and speed.
        /// </summary>
        public static Time TimeFromSV(Distance distance, Speed speed)
        {
            return (double)distance / (double)speed;
        }
        
        /// <summary>
        /// Calculate time from distance, end speed and start speed.
        /// </summary>
        public static Time TimeFromSVU(Distance distance, Speed endSpeed, Speed startSpeed)
        {
            return 2 * (double)distance / ((double)endSpeed + (double)startSpeed);
        }
        
        /// <summary>
        /// Calculate time from end speed, start speed and acceleration.
        /// </summary>
        public static Time TimeFromVUA(Speed endSpeed, Speed startSpeed, Acceleration acceleration)
        {
            return ((double)endSpeed - (double)startSpeed) / (double)acceleration;
        }
        
        /// <summary>
        /// Calculate time from acceleration, distance and start speed.
        /// </summary>
        public static Time TimeFromASU(Acceleration acceleration, Distance distance, Speed startSpeed)
        {
            return (Sqrt(2 * (double)acceleration * (double)distance + Pow2((double)startSpeed)) - (double)startSpeed) / (double)acceleration;
        }
        
        /// <summary>
        /// Calculate time from end speed, acceleration and distance.
        /// </summary>
        public static Time TimeFromVAS(Speed endSpeed, Acceleration acceleration, Distance distance)
        {
            return ((double)endSpeed - Sqrt(Pow2((double)endSpeed) - 2 * (double)acceleration * (double)distance)) / (double)acceleration;
        }
        
        /* Private methods. */
        private static Time Pow2(double value)
        {
            return value * value;
        }
    }
}