using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Vektormathematik
{
    /// <summary>
    /// An object holding an X, Y and Z coordinate value as float datatypes.
    /// </summary>
    public struct Vector
    {
        // Coordinate values of the Vector.
        public float x;
        public float y;
        public float z;

        // Default constructor.
        public Vector()
        {
            x = 0;
            y = 0;
            z = 0;
        }

        // Overloaded constructor.
        public Vector(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        // Adds two Vector objects by seperately adding every value of the first Vector to those of the second Vector.
        public static Vector operator +(
            Vector vector_01,
            Vector vector_02
        ) => new Vector(
            x: vector_01.x + vector_02.x,
            y: vector_01.y + vector_02.y,
            z: vector_01.z + vector_02.z
        );

        // Substracts two Vector objects by seperately subtracting every value of the first Vector with those of the second Vector.
        public static Vector operator -(
            Vector vector_01,
            Vector vector_02
        ) => new Vector(
            x: vector_01.x - vector_02.x,
            y: vector_01.y + vector_02.y,
            z: vector_01.z + vector_02.z
        );

        // Multiplies the Vector with a scalar by creating a new Vector with the values of the original Vector multiplied with that scalar.
        public static Vector operator *(
            Vector vector,
            float scalar
        ) => new Vector(x: scalar * vector.x, y: scalar * vector.y, z: scalar * vector.z);

        /// <summary>
        /// Calculates the distance between two Vector objects.
        /// </summary>
        /// <param name="vector01">
        /// First Vector object.
        /// </param>
        /// <param name="vector02">
        /// Second Vector object.
        /// </param>
        /// <returns>
        /// The distance between two Vector objects as float.
        /// </returns>
        public static float DistanceBetween(Vector vector01, Vector vector02)
        {
            Vector distanceVector = new Vector(
                x: vector01.x - vector02.x,
                y: vector01.y - vector02.y,
                z: vector01.z - vector02.z
            );

            return (float)Math.Sqrt(Math.Sqrt(Math.Pow(distanceVector.x, 2)) + Math.Pow(distanceVector.y, 2) + Math.Pow(distanceVector.z, 2));
        }

        /// <summary>
        /// Calculates the scalar product of two Vector objects.
        /// </summary>
        /// <param name="vector01">
        /// First Vector object.
        /// </param>
        /// <param name="vector02">
        /// Second Vector object.</param>
        /// <returns>
        /// The scalar product of two Vector objects as float.
        /// </returns>
        public static float ScalarProduct(Vector vector01, Vector vector02)
        {
            return vector01.x * vector02.x + vector01.y * vector02.y + vector01.z * vector02.z;
        }

        /// <summary>
        /// Calculates the square of the Vector object.
        /// </summary>
        /// <returns>
        /// The square of the Vector object as float.
        /// </returns>
        public float Square() => (float)(x * x + y * y + z * z);
    }
}
