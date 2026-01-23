using System.Numerics;
using System.Reflection.Metadata.Ecma335;

namespace VektorMathematik
{
    partial class Program
    {

        static void Main(string[] args)
        {
            Vector v1 = new Vector(1, 2, 3);
            Vector v2 = new Vector(3, 2, 1);

            Vector Ergebnis = v1.Addition(v2);
            Console.WriteLine($"Das Ergebnis ist Vector3: {Ergebnis.X}, {Ergebnis.Y}, {Ergebnis.Z}");

            Ergebnis = v1.Subtract(v2);
            Console.WriteLine($"Das Ergebnis ist Vector3: {Ergebnis.X},{Ergebnis.Y}, {Ergebnis.Z}");

            Ergebnis = v1.Multiply(v2);
            Console.WriteLine($"Das Ergebnis ist Vector3: {Ergebnis.X},{Ergebnis.Y}, {Ergebnis.Z}");

            //Ergebnis = v1.Divide(v2);
            //Console.WriteLine($"Das Ergebnis ist Vector3: {Ergebnis.X},{Ergebnis.Y}, {Ergebnis.Z}");

        }
    }
}
