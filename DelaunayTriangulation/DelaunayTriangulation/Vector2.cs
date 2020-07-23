using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelaunayTriangulation
{
    public class Vector2
    {
        public float x { get; set; }
        public float y { get; set; }

        public Vector2(float X, float Y)
        {
            x = X;
            y = Y;
        }

        // Overload operator
        public static Vector2 operator +(Vector2 A, Vector2 B)
        {

            float o = A.x + B.x;
            float p = A.y + B.y;

            Vector2 C = new Vector2(o, p);

            return C;
        }
    }
}
