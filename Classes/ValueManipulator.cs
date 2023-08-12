using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            return  value;
        }
    }
}