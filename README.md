## Delaunay Triangulation

Generic adaptation of Habrador's Delaunay Triangulation approach for Unity

https://www.habrador.com/tutorials/math/11-delaunay/

Example
Begin creating a List of random points
    Random rnd = new Random();
```csharp
List<Vector3> points = new List<Vector3>();
    
for (int n = 0; n <= Points; n++)
{
    float x = Convert.ToSingle(rnd.NextDouble() * Area);
    float y = Convert.ToSingle(rnd.NextDouble() * Area);
    
    Vector3 vc = new Vector3(x, y, 0f);
    
    points.Add(vc);
}
```

Then use

```csharp
List<Triangle> triangulation = Delaunay.TriangulateByFlippingEdges(points);
```

To triangulate them, the values of each ```Triangle``` can be accessed like this

```csharp
foreach (Triangle tri in triangulation)
{
    float v1 = tri.v1.position.x, tri.v1.position.y, tri.v1.position.z;
    float v2 = tri.v2.position.x, tri.v2.position.y, tri.v2.position.z;
    float v3 = tri.v3.position.x, tri.v3.position.y, tri.v3.position.z;
}
```

Where each vertex of the triangle is v1, v2, v3 respectively
