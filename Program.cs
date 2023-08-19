// See https://aka.ms/new-console-template for more information

using Calculator.Interfaces;
using MyCalculator.Classes;

namespace Calculator
{
    class Calculator
    {
        static void Main()
        {
            var menu = new Menu();
            var multiplicationTable = new MultiplicationTable();
            IReporter reporter = new ReporteR();
            CalculatoR calculator;
            bool isRepeat = false;
            do
            {
                menu.ShowMenu();

                int userInput = int.Parse(Console.ReadLine());

                if (userInput == 1)
                {
                    multiplicationTable.ShowMultiplicationTable();
                }

                if (userInput == 2)
                {
                    menu.ShowCalculatorMenu();
                    int userCalculatorInput = int.Parse(Console.ReadLine());

                    switch (userCalculatorInput)
                    {
                        case 1:
                            calculator = new CalculatoR();
                            break;

                        case 2:
                            calculator = new AdvancedCalculatoR();
                            break;

                        default:
                            calculator = new CalculatoR();
                            break;
                    }

                    calculator.Calculate();
                }

                reporter.ShowGratitude();

                Console.WriteLine();
                Console.Write("Do you want to Repeat? [y/n]: ");
                string answer = Console.ReadLine();

                isRepeat = answer == "y" ? true : false;
            }

            while (isRepeat);
        }
    }
}