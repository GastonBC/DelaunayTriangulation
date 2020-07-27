using DelaunayVoronoi;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace CanvasTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DelaunayTriangulator delaunay = new DelaunayTriangulator();
            Voronoi voronoi = new Voronoi();
            int PointCount = 300;

            IEnumerable<DelaunayVoronoi.Point> points = delaunay.GeneratePoints(PointCount, 750, 750);

            IEnumerable<Triangle> triangulation = delaunay.BowyerWatson(points);


            foreach (Triangle tri in triangulation)
            {
                Line line1 = new Line();
                line1.Stroke = Brushes.LightBlue;

                line1.X1 = tri.Vertices[0].X;
                line1.Y1 = tri.Vertices[0].Y;

                line1.X2 = tri.Vertices[1].X;
                line1.Y2 = tri.Vertices[1].Y;
                myCanvas.Children.Add(line1);


                Line line2 = new Line();
                line2.Stroke = Brushes.LightBlue;

                line2.X1 = tri.Vertices[1].X;
                line2.Y1 = tri.Vertices[1].Y;

                line2.X2 = tri.Vertices[2].X;
                line2.Y2 = tri.Vertices[2].Y;

                myCanvas.Children.Add(line2);

                Line line3 = new Line();
                line3.Stroke = Brushes.LightBlue;

                line3.X1 = tri.Vertices[0].X;
                line3.Y1 = tri.Vertices[0].Y;

                line3.X2 = tri.Vertices[0].X;
                line3.Y2 = tri.Vertices[0].Y;

                myCanvas.Children.Add(line3);
            }

            /*
            foreach (DelaunayFromRK.Point pt in points)
            {
                Ellipse el = Dot();

                myCanvas.Children.Add(el);

                Canvas.SetLeft(el, pt.X - (el.Height / 2));
                Canvas.SetTop(el, pt.Y - (el.Height / 2));
            }
            */
        }

        private Ellipse Dot()
        {
            Ellipse el = new Ellipse();
            el.Height = 5;
            el.Width = 5;

            el.Fill = Brushes.Red;

            return el;
        }
    }
}
