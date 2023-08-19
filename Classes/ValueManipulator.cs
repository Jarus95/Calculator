using System.Drawing;

namespace MyCalculator.Classes
{
    public static class ValueManipulator
    {
        public static string GetUserValueFromMessage(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(new string('-', 50));
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static double ConvertUserValueToDouble(string userValue)
        {
            double value = Convert.ToDouble(userValue);
            return value;
        }

        public static int ConvertUserValueToInt(string userValue)
        {
            int value = Convert.ToInt32(userValue);
            return value;
        }
    }
}