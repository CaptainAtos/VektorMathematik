using System;

namespace VektorMathematik
{
    struct Vector
    {
        // Attribute
        public float X;
        public float Y;
        public float Z;

        // Standardkonstruktor (0,0,0)
        public Vector()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }

        // Konstruktor mit Parameterübergabe
        public Vector(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        // Operator +
        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        // Operator -
        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }

        // Operator * Skalar
        public static Vector operator *(Vector v, float s)
        {
            return new Vector(v.X * s, v.Y * s, v.Z * s);
        }

        // Länge des Vektors
        public float Length()
        {
            return MathF.Sqrt(LengthSquared());
        }

        // Quadratlänge
        public float LengthSquared()
        {
            return X * X + Y * Y + Z * Z;
        }

        // Punktprodukt
        public static float Dot(Vector a, Vector b)
        {
            return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
        }

        // Distanz
        public static float Distance(Vector a, Vector b)
        {
            return (a - b).Length();
        }
    }
}
