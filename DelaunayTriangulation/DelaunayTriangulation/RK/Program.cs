using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelaunayFromRK
{
    class Program
    {

        static void Main(string[] args)
        {
            DelaunayTriangulator delaunay = new DelaunayTriangulator();
            Voronoi voronoi = new Voronoi();
            int PointCount = 2000;

            IEnumerable<Point> points = delaunay.GeneratePoints(PointCount, 500, 500);

            IEnumerable<Triangle> triangulation = delaunay.BowyerWatson(points);

            Console.WriteLine(triangulation.Count());
            Console.ReadLine();
            // IEnumerable<Edge> vornoiEdges = voronoi.GenerateEdgesFromDelaunay(triangulation);
        }
    }
}
