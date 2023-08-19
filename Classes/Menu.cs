using System.Drawing;

namespace MyCalculator.Classes
{
    public class Menu
    {
        public void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Show multiplication table");
            Console.WriteLine("2. Mathematical operations");
            Console.WriteLine(new string('-', 50));
        }

        public void ShowCalculatorMenu()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("1. Use Simple Calculator");
            Console.WriteLine("2. Use Advanced Calculator");
        }
    }
}