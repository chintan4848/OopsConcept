using System;

namespace OopsConcept
{
    public class UtilityClass
    {
        public static void ProcessRectangle()
        { 
            Console.WriteLine(PrintMessage.Line);
            Console.WriteLine();

            reEnterLength:
            Console.Write(PrintMessage.RectagleLengthMsg);
            double length = ReadInputValidation();
            if (length == 0)
                goto reEnterLength;

            Console.WriteLine();

            reEnterWidth:
            Console.Write(PrintMessage.RectagleWidththMsg);
            double width = ReadInputValidation();
            if (width == 0)
                goto reEnterWidth;

            Rectangle rectangle = new Rectangle();
            Console.WriteLine();
            Console.WriteLine(PrintMessage.SerialNumberMsg + rectangle.SerialNumber);
            Console.WriteLine(PrintMessage.AreaOfRectangleMsg + rectangle.CalculateArea(length, width));
            Console.WriteLine(PrintMessage.PerimeterOfRectangleMsg + rectangle.CalculatePerimeter());
            Console.WriteLine(rectangle.DisplayClassName());
            Console.WriteLine();
            Console.WriteLine(PrintMessage.PressEnterMsg);
            Console.ReadLine();
        }

        public static void ProcessOval()
        {
            Console.WriteLine(PrintMessage.Line);
            Console.WriteLine();

            reEnterSemiMajor:
            Console.Write(PrintMessage.SemiMajorAxisMsg);
            double semiMajorAxis = ReadInputValidation();
            if (semiMajorAxis == 0)
                goto reEnterSemiMajor;

            Console.WriteLine();

            reEnterSemiMinor:
            Console.Write(PrintMessage.SemiManorAxisMsg);
            double semiMinorAxis = ReadInputValidation();
            if (semiMajorAxis == 0)
                goto reEnterSemiMinor;

            Oval oval = new Oval();
            Console.WriteLine();
            Console.WriteLine(PrintMessage.SerialNumberMsg + oval.SerialNumber);
            Console.WriteLine(PrintMessage.AreaOfOvalMsg + oval.CalculateArea(semiMajorAxis, semiMinorAxis));
            Console.WriteLine(PrintMessage.PerimeterOfOvalMsg + oval.CalculatePerimeter());
            Console.WriteLine(oval.DisplayClassName());
            Console.WriteLine();
            Console.WriteLine(PrintMessage.PressEnterMsg);
            Console.ReadLine();
        }

        public static void ProcessCircle()
        {
            reRun:            
            Console.WriteLine(PrintMessage.Line);
            Console.WriteLine();
            Console.Write(PrintMessage.RadiusMsg);
            double radius = ReadInputValidation();
            if (radius == 0)
                goto reRun;

            Circle circle = new Circle();
            Console.WriteLine();
            Console.WriteLine(PrintMessage.SerialNumberMsg + circle.SerialNumber);
            Console.WriteLine(PrintMessage.AreaOfCircleMsg + circle.CalculateArea(radius, radius));
            Console.WriteLine(PrintMessage.PerimeterOfCircleMsg + circle.CalculatePerimeter());
            Console.WriteLine(circle.DisplayClassName());
            Console.WriteLine();
            Console.WriteLine(PrintMessage.PressEnterMsg);            
            Console.ReadLine();
        }

        public static double ReadInputValidation()
        {
            double value;
           
            if(!double.TryParse(Console.ReadLine(), out value)|| value<0)
            {
                Console.WriteLine(PrintMessage.InvalidMsg);
                Console.ReadLine();
                return 0;
            }
            return value;
        }
        public static double ReadInputValidation(int max)
        {
            double value=ReadInputValidation();
            if (value == 0)
            {
                return 0;
            }
            if (value < 1 || value > max)
            {
                Console.WriteLine(PrintMessage.RangeInvalidMsg, max);
                Console.ReadLine();
                return 0;
            }
            return value;
        }
    }
}
