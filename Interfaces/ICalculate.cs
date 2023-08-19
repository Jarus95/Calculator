namespace Calculator.Interfaces
{
    public interface ICalculate
    {
        double Sum(double firstNumber, double secondNumber);
        double Multiply(double firstNumber, double secondNumber);
        double Substract(double firstNumber, double secondNumber);
        double Divide(double firstNumber, double secondNumber);
        double CalculateRemainder(double firstNumber, double secondNumber);
        double SqeareRoot(double number);
        double Caret(double number, double power);
    }
}
