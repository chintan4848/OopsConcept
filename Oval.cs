using System;

namespace OopsConcept
{
    public class Oval : Shape
    {       
        private double semiMajorAxis;
        private double semiMinorAxis;
        public override double CalculateArea(double semiMajorAxis,double semiMinorAxis)
        {
            this.semiMajorAxis = semiMajorAxis;
            this.semiMinorAxis = semiMinorAxis;
            return Math.PI * semiMajorAxis * semiMinorAxis;
        }
        public override double CalculatePerimeter()
        {       
            return 2 * Math.PI * Math.Sqrt((semiMajorAxis * semiMajorAxis + semiMinorAxis * semiMinorAxis) / 2);
        }
    }
 }
