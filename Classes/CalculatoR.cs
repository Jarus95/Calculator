using System.Drawing;
using Calculator.Interfaces;

namespace MyCalculator.Classes
{
    public class CalculatoR
    {

        protected double FirsNumber { get; set; }
        protected double SecondNumber { get; set; }
        protected decimal Operation { get; set; }
        public string Template { get; set; }

        protected ConsoleColor color;

        protected IReporter reporter;

        public CalculatoR()
        {
            color = ConsoleColor.Green;
            reporter = new ReporteR();
        }

        public virtual void Calculate()
        {
            string firstValue = ValueManipulator.GetUserValueFromMessage("Enter Values\nEnter first number: ", color);
            string operation = ValueManipulator.GetUserValueFromMessage("Operations\n 1) +\n 2) -\n 3) *\n 4) /\n ", color);
            string secondValue = ValueManipulator.GetUserValueFromMessage("Enter second number: ", color);
            reporter.RepotProgress("Converting values...");

            ConvertValues(firstValue, secondValue, operation);

            double result = Operation switch
            {
                1 => Sum(FirsNumber, SecondNumber),
                2 => Substract(FirsNumber, SecondNumber),
                3 => Multiply(FirsNumber, SecondNumber),
                4 => Divide(FirsNumber, SecondNumber),
                5 => CalculateRemainder(FirsNumber, SecondNumber),
                _ => reporter.ReportError("Invalid Input")
            };

            reporter.RepotResult($"{Template} {result}");
        }

        public void ConvertValues(string firstValue, string secondValue, string operation)
        {
            FirsNumber = ValueManipulator.ConvertUserValueToDouble(firstValue);
            SecondNumber = ValueManipulator.ConvertUserValueToDouble(secondValue);
            Operation = ValueManipulator.ConvertUserValueToInt(operation);
        }

        public double Sum(double firstNumber, double secondNumber)
        {
            Template = $"{FirsNumber} + {SecondNumber} =";
            return firstNumber + secondNumber;
        }

        public double Multiply(double firstNumber, double secondNumber)
        {
            Template = $"{FirsNumber} * {SecondNumber} =";
            return firstNumber * secondNumber;
        }

        public double Substract(double firstNumber, double secondNumber)
        {
            Template = $"{FirsNumber} - {SecondNumber} =";

            return firstNumber - secondNumber;
        }

        public double Divide(double firstNumber, double secondNumber)
        {
            Template = $"{FirsNumber} / {SecondNumber} =";
            return firstNumber / secondNumber;
        }

        public double CalculateRemainder(double firstNumber, double secondNumber)
        {
            Template = $"{FirsNumber} % {SecondNumber} =";

            return firstNumber % secondNumber;
        }
    }
}