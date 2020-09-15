using System;

namespace Lab_2.Task_2
{
    class Rectangle
    {
        private readonly double _side1, _side2;

        public double Area { get; }
        public double Perimeter { get; }

        public Rectangle(double side1, double side2)
        {
            _side1 = side1;
            _side2 = side2;
            Area = AreaCalculator();
            Perimeter = PerimeterCalculator();
            Console.WriteLine($"Perimeter: {Perimeter},\nArea: {Area}.");
        }

        public double AreaCalculator() => _side1 * _side2;

        public double PerimeterCalculator() => 2 * (_side1 + _side2);
        
        
    }
}
