using System;
using CalculationLib;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double a, b, result;

            Console.Write("Введите первое число: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            b = double.Parse(Console.ReadLine());

            result = Calculation.Plus(a, b);
            Console.WriteLine($"{a} + {b} = {result}");

            result = Calculation.Minus(a, b);
            Console.WriteLine($"{a} - {b} = {result}");

            result = Calculation.Divide(a, b);
            Console.WriteLine($"{a} / {b} = {result}");

            result = Calculation.Multiply(a, b);
            Console.WriteLine($"{a} * {b} = {result}");

            Console.ReadLine();
        }
    }
}
