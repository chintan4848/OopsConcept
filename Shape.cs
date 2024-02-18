namespace OopsConcept
{
        public abstract class Shape
        {
            private int serialCounter = 0;
            protected int serialNumber;
            public Shape()
            {
                serialNumber = ++serialCounter;
            }

            // Property to get serial number
            public int SerialNumber
            {
                get { return serialNumber; }
            }
            public abstract double CalculateArea(double Value1,double Value2);
            public abstract double CalculatePerimeter();

            public string DisplayClassName()
            {
                return PrintMessage.ClassNameMsg + this.GetType().Name;
            }
        }
}
