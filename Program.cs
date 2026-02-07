using System;

namespace VektorMathematik
{
    internal class Program
    {
        static void Main()  
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                ShowMenu();

                Console.Write("Auswahl: ");
                string input = Console.ReadLine()!;

                switch (input)
                {
                    case "1": // Addition
                        Vector a1 = ReadVector("Vektor A");
                        Vector b1 = ReadVector("Vektor B");
                        Vector add = a1 + b1;
                        PrintVector("Ergebnis", add);
                        break;

                    case "2": // Subtraktion
                        Vector a2 = ReadVector("Vektor A");
                        Vector b2 = ReadVector("Vektor B");
                        Vector sub = a2 - b2;
                        PrintVector("Ergebnis", sub);
                        break;

                    case "3": // Skalarmultiplikation
                        Vector v = ReadVector("Vektor");
                        float scalar = ReadFloat("Skalar");
                        Vector mul = v * scalar;
                        PrintVector("Ergebnis", mul);
                        break;

                    case "4": // Länge eines Vektors als flaot 
                        Vector vLen = ReadVector("Vektor");
                        Console.WriteLine($"Länge: {vLen.Length()}");
                        break;

                    case "5": //  Distanz zwischen zwei Vektoren
                        Vector d1 = ReadVector("Vektor A");
                        Vector d2 = ReadVector("Vektor B");
                        Console.WriteLine($"Distanz: {Vector.Distance(d1, d2)}");
                        break;

                    case "6": // Punktprodukt
                        Vector p1 = ReadVector("Vektor A");
                        Vector p2 = ReadVector("Vektor B");
                        Console.WriteLine($"Punktprodukt: {Vector.Dot(p1, p2)}");
                        break;

                    case "7": // Quadratlänge
                        Vector vSq = ReadVector("Vektor");
                        Console.WriteLine($"Quadratlänge: {vSq.LengthSquared()}");
                        break;

                    case "0":
                        running = false;
                        continue;

                    default:
                        Console.WriteLine("Ungültige Eingabe!");
                        break;
                }

                Console.WriteLine("Enter drücken um fortzufahren");
                Console.ReadLine();
            }
        }

        static void ShowMenu() // Schreibt lediglich das Menü nach dem Starten der Anwendung
        {
            Console.WriteLine(" Vektor Mathematik ");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraktion");
            Console.WriteLine("3 - Skalarmultiplikation");
            Console.WriteLine("4 - Länge eines Vektors");
            Console.WriteLine("5 - Distanz zweier Vektoren");
            Console.WriteLine("6 - Punktprodukt");
            Console.WriteLine("7 - Quadratlänge eines Vektors");
            Console.WriteLine("0 - Beenden");
        }

        static Vector ReadVector(string name)  // Liest die Userangaben aus und übergibt diese dann dem Konstruktor um eine Vektorklasse zu deklarieren
        {
            Console.WriteLine($"\n{name}:");
            float x = ReadFloat("X");
            float y = ReadFloat("Y");
            float z = ReadFloat("Z");
            return new Vector(x, y, z);
        }

        static float ReadFloat(string name)  // Überprüft ob der Input einem float entspricht und gib diesen dann wieder
        {
            float value;
            bool isValid;

            do
            {
                Console.Write($"{name}: ");
                string input = Console.ReadLine()!;

                isValid = float.TryParse(input, out value);

                if (!isValid)
                {
                    Console.WriteLine("Falsche Eingabe, bitte eine Zahl eingeben!");
                }

            } while (!isValid);

            return value;
        }

        static void PrintVector(string name, Vector v)  // Schreibt die Lösung der Vektorrechnungen auf
        {
            Console.WriteLine($"{name}: ({v.X}, {v.Y}, {v.Z})");
        }
    }
}
