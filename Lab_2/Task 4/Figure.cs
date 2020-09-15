using System;
using System.Collections.Generic;

namespace Lab_2.Task_4
{
    class Figure
    {
        private readonly List<Point> _points = new List<Point>();

        public Figure(Point a, Point b, Point c)
        {
            _points.Add(a);
            _points.Add(b);
            _points.Add(c);
        }
        public Figure(Point a, Point b, Point c, Point d)
        {
            _points.Add(a);
            _points.Add(b);
            _points.Add(c);
            _points.Add(d);
        }
        public Figure(Point a, Point b, Point c, Point d, Point e)
        {
            _points.Add(a);
            _points.Add(b);
            _points.Add(c);
            _points.Add(d);
            _points.Add(e);
        }
        /*public Figure(Point[] points)
        {
            if (points.Length > 2 && points.Length < 6)
                foreach (Point point in points)
                    _points.Add(point);
        }*/

        private double LengthSide(Point a, Point b) => Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));

        public double PerimeterCalculator()
        {
            double perimeter = 0;
            for(int i = 0; i < _points.Count; i++)
                perimeter += LengthSide(_points[i], i + 1 < _points.Count ? _points[i + 1] : _points[0]);
            return perimeter;
        }

        public string Name()
        {
            string name = "";
            foreach (Point point in _points) name += point.Text;
            return name;
        }
    }
}