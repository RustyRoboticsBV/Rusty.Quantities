using System;

namespace Rusty.Quantities
{
    /// <summary>
    /// A 2D distance quantity.
    /// </summary>
    [Serializable]
    public readonly struct Distance2
    {
        /* Fields. */
        private readonly Distance x;
        private readonly Distance y;

        /* Public properties. */
        /// <summary>
        /// The first internal value of this 2D distance quantity.
        /// </summary>
        public readonly Distance X => x;
        /// <summary>
        /// The second internal value of this 2D distance quantity.
        /// </summary>
        public readonly Distance Y => y;

        /* Constructors. */
        /// <summary>
        /// Create a new 2D distance quantity.
        /// </summary>
        public Distance2(Distance x, Distance y)
        {
            this.x = x;
            this.y = y;
        }
    }
}