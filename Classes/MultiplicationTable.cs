using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCalculator.Classes
{
    public class MultiplicationTable
    {
        public void ShowMultiplicationTable()
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
    }
}