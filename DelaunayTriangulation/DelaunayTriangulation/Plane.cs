using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelaunayTriangulation
{
    public class Plane
    {
        public Vector3 pos;

        public Vector3 normal;

        public Plane(Vector3 pos, Vector3 normal)
        {
            this.pos = pos;

            this.normal = normal;
        }
    }
}
