namespace Vektormathematik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(x: 5, y: 10, z: 2);
            Vector v2 = new Vector(x: 2, y: 2, z: 7);

            Console.WriteLine("Vektorensumme:");
            Console.WriteLine(v1 + v2);
            Console.WriteLine("Vektorendifferenz:");
            Console.WriteLine(v1 - v2);
            Console.WriteLine("Vektorenprodukt / Skalar:");
            Console.WriteLine(v1 * v2);
            Console.WriteLine("Distanz zwischen beiden Vektoren:");
            Console.WriteLine(v1.DistanceTo(v2));
            Console.WriteLine("Quadratlänge:");
            Console.WriteLine(v1.Square());
        }
    }
}
