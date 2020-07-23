using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DelaunayTriangulation
{
    public class Vector3
    {
        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }

        public Vector3(float X, float Y, float Z)
        {
            x = X;
            y = Y;
            z = Z;
        }

        // Overload operators
        public static Vector3 operator+ (Vector3 A, Vector3 B)
        {

            float o = A.x + B.x;
            float p = A.y + B.y;
            float q = A.z + B.z;

            Vector3 C = new Vector3(o, p, q);

            return C;
        }
        public static Vector3 operator /(Vector3 A, float b)
        {
            if (b == 0f )
            {
                throw new DivideByZeroException();
            }

            float o = A.x / b;
            float p = A.y / b;
            float q = A.z / b;

            Vector3 C = new Vector3(o, p, q);

            return C;
        }
    }
}
