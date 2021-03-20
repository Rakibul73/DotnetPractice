using System;

namespace DotnetPractice
{
    public class ParentClass
    {
       
        private double _radious;
        public ParentClass(double radious)
        {
            _radious = radious;
        }
    }

    class DerivedClass : ParentClass
    {
        public DerivedClass() : base(5)
        {

        }
    }

    
}