using System;

namespace Rusty.Quantities
{
    /// <summary>
    /// A 3D distance quantity.
    /// </summary>
    [Serializable]
    public readonly struct Distance3
    {
        /* Fields. */
        private readonly Distance x;
        private readonly Distance y;
        private readonly Distance z;

        /* Public properties. */
        /// <summary>
        /// The first internal value of this 3D distance quantity.
        /// </summary>
        public readonly Distance X => x;
        /// <summary>
        /// The second internal value of this 3D distance quantity.
        /// </summary>
        public readonly Distance Y => y;
        /// <summary>
        /// The third internal value of this 3D distance quantity.
        /// </summary>
        public readonly Distance Z => z;

        /* Constructors. */
        /// <summary>
        /// Create a new 3D distance quantity.
        /// </summary>
        public Distance3(Distance x, Distance y, Distance z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}