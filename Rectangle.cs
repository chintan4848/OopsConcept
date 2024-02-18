namespace OopsConcept
{
    public class Rectangle : Shape
    {
        private double length;
        private double width;
        public override double CalculateArea(double length,double width)
        {
            this.length = length;
            this.width = width;

            return length * width;
        }
        public override double CalculatePerimeter()
        {
            return 2 * (length + width);
        }
    }

}
