using Calculator.Interfaces;

namespace MyCalculator.Classes
{
    public class ReporteR : IReporter
    {
        public void ShowGratitude()
        {
            Console.WriteLine("Thank you for using our Calculator");
        }

        public void RepotProgress(string message)
        {
            Console.WriteLine(message);
        }

        public void RepotResult(string result)
        {
            Console.WriteLine(result);
        }

        public int ReportError(string errorMessage)
        {
            Console.WriteLine(errorMessage);
            return -1;
        }
    }
}