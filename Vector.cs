using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Vektormathematik
{
    public struct Vector
    {
        public float x { get; set; }
        public float y;
        public float z;
        public Vector()
        {
            x = 0;
            y = 0;
            z = 0;
        }
        public Vector(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Vector operator +(
            Vector vector_01,
            Vector vector_02
        ) => new Vector(
            x: vector_01.x + vector_02.x,
            y: vector_01.y + vector_02.y,
            z: vector_01.z + vector_02.z
        );
        public static Vector operator -(
            Vector vector_01,
            Vector vector_02
        ) => new Vector(
            x: vector_01.x - vector_02.x,
            y: vector_01.y + vector_02.y,
            z: vector_01.z + vector_02.z
        );

        public static float operator *(
            Vector vector_01,
            Vector vector_02
        ) => vector_01.x * vector_02.x + vector_02.y * vector_02.y + vector_02.z * vector_02.z;

        public float DistanceTo(Vector target)
        {
            Vector distanceVector = new Vector(
                x: target.x - this.x,
                y: target.y - this.y,
                z: target.z - this.z
            );

            return (float)Math.Sqrt(Math.Sqrt(Math.Pow(distanceVector.x,2))+ Math.Pow(distanceVector.y, 2) + Math.Pow(distanceVector.z,2));
        }

        public float Square() => (float)(x * x + y * y + z * z);
    }
}
