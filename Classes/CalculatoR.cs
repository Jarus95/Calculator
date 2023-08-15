namespace MyCalculator.Classes
{
    public class CalculatoR
    {
        protected string FirstValue { get; set; }
        protected string Operation { get; set; }
        protected string SecondValue { get; set; }
        protected decimal FirsNumber { get; set; }
        protected decimal SecondNumber { get; set; }
        public virtual void Calculate()
        {
            FirstValue = ValueManipulator.GetUserValueFromMessage("Enter Values\nEnter first number: ");
            Operation = ValueManipulator.GetUserValueFromMessage("Operations [+ - * /]: ");
            SecondValue = ValueManipulator.GetUserValueFromMessage("Enter second number: ");
            ReporteR.RepotProgress("Converting values...");

            FirsNumber = ValueManipulator.ConvertUserValueToDecimal(FirstValue);
            SecondNumber = ValueManipulator.ConvertUserValueToDecimal(SecondValue);

            string template = $"{FirsNumber} {Operation} {SecondNumber} =";
            decimal result = Operation switch
            {
                "+" => Sum(FirsNumber, SecondNumber),
                "-" => Substract(FirsNumber, SecondNumber),
                "*" => Multiply(FirsNumber, SecondNumber),
                "/" => Divide(FirsNumber, SecondNumber),
                "%" => CalculateRemainder(FirsNumber, SecondNumber),
                _ => 0
            };

            ReporteR.RepotResult($"{template} {result}");
        }

        public decimal Sum(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public decimal Multiply(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public decimal Substract(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public decimal Divide(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber / secondNumber;
        }

        public decimal CalculateRemainder(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber % secondNumber;
        }
    }
}