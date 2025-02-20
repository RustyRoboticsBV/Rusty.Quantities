namespace Rusty.Quantities
{
    /// <summary>
    /// A scalar quantity type, based on the double type.
    /// </summary>
    public interface IScalarQuantity
    {
        /// <summary>
        /// The internal value of this quantity.
        /// </summary>
        public double Value { get; }
    }
}