using System;

namespace Rusty.Quantities
{
    /// <summary>
    /// A 3D acceleration quantity.
    /// </summary>
    [Serializable]
    public readonly struct Acceleration3
    {
        /* Fields. */
        private readonly Acceleration x;
        private readonly Acceleration y;
        private readonly Acceleration z;

        /* Public properties. */
        /// <summary>
        /// The first internal value of this 3D acceleration quantity.
        /// </summary>
        public readonly Acceleration X => x;
        /// <summary>
        /// The second internal value of this 3D acceleration quantity.
        /// </summary>
        public readonly Acceleration Y => y;
        /// <summary>
        /// The third internal value of this 3D acceleration quantity.
        /// </summary>
        public readonly Acceleration Z => z;

        /* Constructors. */
        /// <summary>
        /// Create a new 3D acceleration quantity.
        /// </summary>
        public Acceleration3(Acceleration x, Acceleration y, Acceleration z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}