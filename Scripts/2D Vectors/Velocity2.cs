using System;

namespace Rusty.Quantities
{
    /// <summary>
    /// A 2D velocity quantity.
    /// </summary>
    [Serializable]
    public readonly struct Velocity2
    {
        /* Fields. */
        private readonly Speed x;
        private readonly Speed y;

        /* Public properties. */
        /// <summary>
        /// The first internal value of this 2D velocity quantity.
        /// </summary>
        public readonly Speed X => x;
        /// <summary>
        /// The second internal value of this 2D velocity quantity.
        /// </summary>
        public readonly Speed Y => y;

        /* Constructors. */
        /// <summary>
        /// Create a new 2D velocity quantity.
        /// </summary>
        public Velocity2(Speed x, Speed y)
        {
            this.x = x;
            this.y = y;
        }
    }
}