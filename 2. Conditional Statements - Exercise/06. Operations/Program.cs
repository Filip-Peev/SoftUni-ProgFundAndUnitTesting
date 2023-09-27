﻿namespace _06._Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            char mathOperator = char.Parse(Console.ReadLine());

            switch (mathOperator)
            {
                case '+':
                    if ((a + b) % 2 == 0)
                    {
                        Console.WriteLine($"{a} + {b} = {a + b} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{a} + {b} = {a + b} - odd");
                    }
                    break;
                case '-':
                    if ((a - b) % 2 == 0)
                    {
                        Console.WriteLine($"{a} - {b} = {a - b} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{a} - {b} = {a - b} - odd");
                    }
                    break;
                case '*':
                    if ((a * b) % 2 == 0)
                    {
                        Console.WriteLine($"{a} * {b} = {a * b} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{a} * {b} = {a * b} - odd");
                    }
                    break;
                case '/':
                    if (b == 0)
                    {
                        Console.WriteLine($"Cannot divide {a} by zero");
                    }
                    else
                    {
                        double sum = (a * 1.0) / (b * 1.0);
                        Console.WriteLine($"{a} / {b} = {sum:F2}");
                    }
                    break;
                case '%':
                    if (b == 0)
                    {
                        Console.WriteLine($"Cannot divide {a} by zero");
                    }
                    else
                    {
                    Console.WriteLine($"{a} % {b} = {a % b}");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}