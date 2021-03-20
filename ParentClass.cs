using System;

namespace DotnetPractice
{
    public class ParentClass
    {

        public double Perimeter = 20; 
        protected double _radious;
        public ParentClass(double radious)
        {
            _radious = radious;
        }

        public double CalculateArea()
        {
            return _radious * _radious * Circle.pi;
        }
    }

    class DerivedClass : ParentClass
    {
        public new double Perimeter; 
        public DerivedClass() : base(Convert.ToDouble(Console.ReadLine()))
        {
            Perimeter = _radious * 2 * Circle.pi;
        }
        public new double CalculateArea()
        {
            return base._radious * (Perimeter / 2);
        }
    }

    
}