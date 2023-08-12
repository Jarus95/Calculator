// See https://aka.ms/new-console-template for more information

using System;
using MyCalculator.Classes;

namespace  Calculator
{
    class Calculator
    {
       static void Main()
       {
           var menu = new Menu();
           var multiplicationTable = new MultiplicationTable();
           var calculator = new CalculatoR();
           bool isRepeat = false;
           do
           {            
             menu.ShowMenu();

             int userInput = int.Parse(Console.ReadLine());
             if(userInput == 1)
             {
                 multiplicationTable.ShowMultiplicationTable();
             }

             if(userInput == 2)
             {
                calculator.Calculate();
             }

             ReporteR.ShowGratitude();

             Console.WriteLine();
             Console.Write("Do you want to Repeat? [y/n]: ");
             string answer = Console.ReadLine();

             isRepeat = answer == "y" ? true : false; 
         }

         while(isRepeat);
       }
    }
}