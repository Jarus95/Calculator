using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCalculator.Classes
{
    public static class ReporteR
    {
        public static void ShowGratitude()
        {
            Console.WriteLine("Thank you for using our Calculator");
        }

        public static void RepotProgress(string message)
        {
            Console.WriteLine(message);
        }

        public static void RepotResult(string result)
        {
            Console.WriteLine(result);
        }
    }
}