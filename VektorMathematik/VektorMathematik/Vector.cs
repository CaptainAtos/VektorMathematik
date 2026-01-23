namespace VektorMathematik
{
    partial class Program
    {
        class Vector
        {
            public float X = 0;
            public float Y = 0;
            public float Z = 0;

            public Vector(float x, float y, float z)
            {
                X = x;
                Y = y;
                Z = z;
            }
            public Vector Addition(Vector oV)
            {
                return new Vector(X + oV.X, Y + oV.Y, Z + oV.Z);

            }

            public Vector Subtract(Vector oV) 
            {
                return new Vector(X - oV.X, Y - oV.Y, Z - oV.Z);
            }

            public Vector Multiply(Vector oV) 
            {
                return new Vector(X * 2, Y * 2, Z * 2);
            
            }

            //public Vector Divide(Vector oV) 
            //{
            //    return new Vector(X / oV.X, Y / oV.Y, Z / oV.Z);
            //}
        }
    }
}
