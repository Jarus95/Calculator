using Calculator.Interfaces;

namespace MyCalculator.Classes
{
    public class AdvancedCalculatoR : CalculatoR, ICalculate
    {
        public AdvancedCalculatoR() =>
            color = ConsoleColor.Yellow;
        
        public override void Calculate()
        {
            string firstValue = ValueManipulator.GetUserValueFromMessage("Enter Values\nEnter first number: ", color);
            string operation = ValueManipulator.GetUserValueFromMessage("Operations\n 1) +\n 2) -\n 3) *\n 4) /\n 5) %\n 6) √a\n 7) a^b\n ", color);
            string secondValue = "0";

            if (!operation.Equals("6"))
                secondValue = ValueManipulator.GetUserValueFromMessage("Enter second number: ", color);

            reporter.RepotProgress("Converting values...");

            ConvertValues(firstValue, secondValue, operation); ;

            double result = Operation switch
            {
                1 => Sum(FirsNumber, SecondNumber),
                2 => Substract(FirsNumber, SecondNumber),
                3 => Multiply(FirsNumber, SecondNumber),
                4 => Divide(FirsNumber, SecondNumber),
                5 => CalculateRemainder(FirsNumber, SecondNumber),
                6 => SqeareRoot(FirsNumber),
                7 => Caret(FirsNumber, SecondNumber),
                _ => reporter.ReportError("Invalid Input")
            };

            reporter.RepotResult($"{Template} {result}");
        }

        public double SqeareRoot(double number)
        {
            Template = $"√{number} = ";
            return Math.Sqrt(number);
        }
        public double Caret(double number, double power)
        {
            Template = $"{number}^{power} = ";
            return Math.Pow(number, (int)power);
        }
    }
}