namespace MyCalculator.Classes
{
    public static class ValueManipulator
    {
        public static string GetUserValueFromMessage(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static decimal ConvertUserValueToDecimal(string userValue)
        {
            decimal value = Convert.ToDecimal(userValue);
            return value;
        }
    }
}