using System;

namespace Rusty.Quantities
{
    /// <summary>
    /// A 2D acceleration quantity.
    /// </summary>
    [Serializable]
    public readonly struct Acceleration2
    {
        /* Fields. */
        private readonly Acceleration x;
        private readonly Acceleration y;

        /* Public properties. */
        /// <summary>
        /// The first internal value of this 2D acceleration quantity.
        /// </summary>
        public readonly Acceleration X => x;
        /// <summary>
        /// The second internal value of this 2D acceleration quantity.
        /// </summary>
        public readonly Acceleration Y => y;

        /* Constructors. */
        /// <summary>
        /// Create a new 2D acceleration quantity.
        /// </summary>
        public Acceleration2(Acceleration x, Acceleration y)
        {
            this.x = x;
            this.y = y;
        }
    }
}