using System;

namespace DotnetPractice
{
    public class Circle
    {
        public double _radious;
        public static double pi = Math.PI;
        public double CalculateArea()
        {
            return _radious * _radious * pi;
        }

        public Circle(double radious)
        {
            _radious = radious;
        }
        

        public Circle() : this(5)
        {
            
        }

        ~Circle()
        {
            // Clean up code
        }
    }
}