namespace Vektormathematik
{
    internal class Program
    {
        /// <summary>
        /// Prints the values of a specific Vector object to the console. Made for debugging purposes in the first place.
        /// </summary>
        /// <param name="vector">
        /// The Vector object to print the values of.
        /// </param>
        private static void PrintVector(Vector vector)
        {
            Console.WriteLine($"X: {vector.X}\nY: {vector.Y}\nZ: {vector.Z}");
        }

        static void Main(string[] args)
        {
            Vector v1 = new Vector(x: 5, y: 10, z: 2);
            Vector v2 = new Vector(x: 5, y: 0, z: 2);

            Console.WriteLine("Vektorensumme:");
            PrintVector(v1 + v2);

            Console.WriteLine("Vektorendifferenz:");
            PrintVector(v1 - v2);

            Console.WriteLine("Multiplikation mit Skalar:");
            PrintVector(v1 * 2.5f);

            Console.WriteLine("Distanz zwischen beiden Vektoren:");
            Console.WriteLine(Vector.DistanceBetween(v1, v2));

            Console.WriteLine("Quadratlänge von Vektor v1:");
            Console.WriteLine(v1.Square());

            Console.WriteLine("Länge von Vektor v1:");
            Console.WriteLine(v1.Length());

            Console.WriteLine("Einheitsvektor von Vektor v1:");
            PrintVector(v1.ToUnit());

            Console.WriteLine("Skalarprodukt:");
            Console.WriteLine(Vector.ScalarProduct(v1,v2));

            Console.WriteLine("Kreuzprodukt:");
            PrintVector(Vector.CrossProduct(v1, v2));
        }
    }
}
