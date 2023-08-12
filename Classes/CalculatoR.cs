using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCalculator.Classes
{
    public class CalculatoR
    {
        public void Calculate()
        {
             string firstValue = ValueManipulator.GetUserValueFromMessage("Enter Values\nEnter first number: ");
             string operation = ValueManipulator.GetUserValueFromMessage("Operations [+ - * /]: ");
             string secondValue = ValueManipulator.GetUserValueFromMessage("Enter second number: ");
             ReporteR.RepotProgress("Converting values...");

             decimal firsNumber = ValueManipulator.ConvertUserValueToDecimal(firstValue);
             decimal secondNumber = ValueManipulator.ConvertUserValueToDecimal(secondValue);

             string template = $"{firsNumber} {operation} {secondNumber} =";
             decimal result = operation switch
             {
                "+" => Sum(firsNumber, secondNumber),
                "-" => Substract(firsNumber, secondNumber),
                "*" => Multiply(firsNumber, secondNumber),
                "/" => Divide(firsNumber, secondNumber),
                "%" => CalculateRemainder(firsNumber, secondNumber),
                 _  => 0              
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