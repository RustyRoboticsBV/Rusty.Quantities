using System;

namespace Rusty.Quantities
{
    /// <summary>
    /// A 3D velocity quantity.
    /// </summary>
    [Serializable]
    public readonly struct Velocity3
    {
        /* Fields. */
        private readonly Speed x;
        private readonly Speed y;
        private readonly Speed z;

        /* Public properties. */
        /// <summary>
        /// The first internal value of this 3D velocity quantity.
        /// </summary>
        public readonly Speed X => x;
        /// <summary>
        /// The second internal value of this 3D velocity quantity.
        /// </summary>
        public readonly Speed Y => y;
        /// <summary>
        /// The third internal value of this 3D velocity quantity.
        /// </summary>
        public readonly Speed Z => z;

        /* Constructors. */
        /// <summary>
        /// Create a new 3D velocity quantity.
        /// </summary>
        public Velocity3(Speed x, Speed y, Speed z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}