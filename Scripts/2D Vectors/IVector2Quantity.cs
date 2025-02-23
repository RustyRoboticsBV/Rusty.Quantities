namespace Rusty.Quantities
{
    /// <summary>
    /// A 2D vector quantity type, based on the double type.
    /// </summary>
    public interface IVector2Quantity
    {
        /// <summary>
        /// The first internal value of this quantity.
        /// </summary>
        public double X { get; }
        /// <summary>
        /// The second internal value of this quantity.
        /// </summary>
        public double Y { get; }
    }
}