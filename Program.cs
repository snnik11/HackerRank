using System;
using Recursive_Digit_Sum;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var rg = new RecDigitSum();
           rg.superDigit("148", 3);
        }
    }
}