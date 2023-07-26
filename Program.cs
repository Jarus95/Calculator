// See https://aka.ms/new-console-template for more information

using System;
namespace  Calculator
{
    class Calculator
    {
       static void Main()
       {
           bool isRepeat = false;

           do
           {
             Console.WriteLine("1. Show multiplication table");
             Console.WriteLine("2. Mathematical operations");

             int userInput = int.Parse(Console.ReadLine());
             if(userInput == 1)
             {
                for(int outerIteration = 2; outerIteration <= 9; outerIteration++)
                {
                    Console.WriteLine(new string('-', 50));
                    for(int iteration = 1; iteration <= 9; iteration++)
                    {
                       Console.WriteLine($"{outerIteration} * {iteration} = {outerIteration * iteration}");
                    }
                }
             }
             if(userInput == 2)
             {
                Console.WriteLine("Enter Values");
                Console.Write("Enter first number: ");
                string firstValue= Console.ReadLine();
                Console.Write("Operations [+ - * /]: ");
                string operation = Console.ReadLine();
                Console.Write("Enter second number: ");
                string secondValue = Console.ReadLine();
                Console.WriteLine("Converting values...");
       
                decimal firsNumber = decimal.Parse(firstValue);
                decimal secondNumber = decimal.Parse(secondValue);
                
                string template = $"{firsNumber} {operation} {secondNumber} =";
                decimal result = operation switch
                {
                   "+" => firsNumber + secondNumber,
                   "-" => firsNumber - secondNumber,
                   "*" => firsNumber * secondNumber,
                   "/" => firsNumber / secondNumber,
                   "%" => firsNumber % secondNumber,
                    _  => 0              
                };
        
                Console.WriteLine($"{template} {result}"); 
             }

         
             Console.WriteLine();
             Console.Write("Do you want to Repeat? [y/n]: ");
             string answer = Console.ReadLine();

             isRepeat = answer == "y" ? true : false; 
         }

         while(isRepeat);
       }
    }
}