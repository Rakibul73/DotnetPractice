using System;

namespace DotnetPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //For Static Member PI, we can access without creating object.

            double myPi = Circle.pi;

            //For instance member we have to create object, then we can access this.
            Circle cs = new Circle();
            double myRadious = cs._radious;
        }
    }
}
