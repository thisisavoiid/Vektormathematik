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
        public float X;
        public float Y;
        public float Z;

        // Default constructor.
        public Vector()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }

        // Overloaded constructor.
        public Vector(float x, float y, float z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        // Adds two Vector objects by seperately adding every value of the first Vector to those of the second Vector.
        public static Vector operator +(
            Vector vector_01,
            Vector vector_02
        ) => new Vector(
            x: vector_01.X + vector_02.X,
            y: vector_01.Y + vector_02.Y,
            z: vector_01.Z + vector_02.Z
        );

        // Substracts two Vector objects by seperately subtracting every value of the first Vector with those of the second Vector.
        public static Vector operator -(
            Vector vector_01,
            Vector vector_02
        ) => new Vector(
            x: vector_01.X - vector_02.X,
            y: vector_01.Y + vector_02.Y,
            z: vector_01.Z + vector_02.Z
        );

        // Multiplies the Vector with a scalar by creating a new Vector with the values of the original Vector multiplied with that scalar.
        public static Vector operator *(
            Vector vector,
            float scalar
        ) => new Vector(x: scalar * vector.X, y: scalar * vector.Y, z: scalar * vector.Z);

        /// <summary>
        /// Calculates the distance between two <see cref="Vector"/> objects.
        /// </summary>
        /// <param name="vector01">
        /// First <see cref="Vector"/> object.
        /// </param>
        /// <param name="vector02">
        /// Second <see cref="Vector"/> object.
        /// </param>
        /// <returns>
        /// The distance between two <see cref="Vector"/> objects as float.
        /// </returns>
        public static float DistanceBetween(Vector vector01, Vector vector02)
        {
            Vector distanceVector = new Vector(
                x: vector01.X - vector02.X,
                y: vector01.Y - vector02.Y,
                z: vector01.Z - vector02.Z
            );

            return (float)Math.Sqrt(Math.Sqrt(Math.Pow(distanceVector.X, 2)) + Math.Pow(distanceVector.Y, 2) + Math.Pow(distanceVector.Z, 2));
        }

        /// <summary>
        /// Calculates the scalar product of two <see cref="Vector"/> objects.
        /// </summary>
        /// <param name="vector01">
        /// First <see cref="Vector"/> object.
        /// </param>
        /// <param name="vector02">
        /// Second <see cref="Vector"/> object.</param>
        /// <returns>
        /// The scalar product of two <see cref="Vector"/> objects as float.
        /// </returns>
        public static float ScalarProduct(Vector vector01, Vector vector02)
        {
            return vector01.X * vector02.X + vector01.Y * vector02.Y + vector01.Z * vector02.Z;
        }

        /// <summary>
        /// Calculates the square of the <see cref="Vector"/> object.
        /// </summary>
        /// <returns>
        /// The square of the <see cref="Vector"/> object as float.
        /// </returns>
        public float Square() => (float)(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2));

        /// <summary>
        /// Calculates the length of the <see cref="Vector"/> object.
        /// </summary>
        /// <returns>
        /// The length of the <see cref="Vector"/> object as float.
        /// </returns>
        public float Length() => (float)Math.Sqrt(this.Square());

        /// <summary>
        /// Calculates the unit <see cref="Vector"/> of the <see cref="Vector"/> object.
        /// </summary>
        /// <returns>
        /// The unit <see cref="Vector"/> of the <see cref="Vector"/> object as float.
        /// </returns>
        public Vector ToUnit() => new Vector(X / Length(), Y / Length(), Z / Length());

        /// <summary>
        /// Calculates the cross product of two <see cref="Vector"/> objects as <see cref="Vector"/>.
        /// </summary>
        /// /// <param name="vector01">
        /// First <see cref="Vector"/> object.
        /// </param>
        /// <param name="vector02">
        /// Second <see cref="Vector"/> object.</param>
        /// <returns>
        /// The cross product of two <see cref="Vector"/> objects as <see cref="Vector"/>
        /// </returns>
        public static Vector CrossProduct(Vector vector01, Vector vector02)
        {
            return new Vector(
                x: (vector01.Y * vector02.Z - vector01.Z * vector02.Y),
                y: (vector01.Z * vector02.X - vector01.X * vector02.Z),
                z: (vector01.X * vector02.Y - vector01.Y * vector02.X)
            );
        }

    }
}
