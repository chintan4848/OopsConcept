using System;

namespace OopsConcept
{
    public class Circle : Oval
    {
        private double radius;
        public override double CalculateArea(double redius, double redius2)
        {
            this.radius = redius;
            return Math.PI* redius *  redius;
        }
        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}
