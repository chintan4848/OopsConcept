using System;

namespace OopsConcept
{
    public class ShapeMenu
    {
        public static void GetShapeChoice()
        {
        reRun:
            Console.Clear();
            Console.WriteLine(PrintMessage.SelectShapeMsg);
            Console.WriteLine(PrintMessage.RactangleMsg);
            Console.WriteLine(PrintMessage.OvalMsg);
            Console.WriteLine(PrintMessage.CircleMsg);
            Console.WriteLine(PrintMessage.ExitMsg);
            Console.Write(PrintMessage.EnterChoiceMsg);

            int maxLength = Enum.GetNames(typeof(EnumShapeType)).Length;
            int choice = (int)UtilityClass.ReadInputValidation(maxLength);
            if (choice == 0)
                goto reRun;
                                  
            switch ((EnumShapeType)choice)
            {
                case EnumShapeType.Rectangle:
                    UtilityClass.ProcessRectangle();
                    break;
                case EnumShapeType.Oval:
                    UtilityClass.ProcessOval();
                    break;
                case EnumShapeType.Circle:
                    UtilityClass.ProcessCircle();
                    break;
                case EnumShapeType.Exit:
                    Console.WriteLine(PrintMessage.ExitProgramMsg);
                    System.Environment.Exit(0);
                    break;
            }
            goto reRun;            
        }
    }
}
