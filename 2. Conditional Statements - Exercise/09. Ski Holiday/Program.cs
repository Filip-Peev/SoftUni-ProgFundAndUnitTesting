using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;

namespace _09._Ski_Holiday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string ass = Console.ReadLine();

            double price = 0.0;

            int nights = days - 1;

            switch (type)
            {
                case "apartment":
                    price = 155.0;
                    if (days > 15)
                    {                    
                        price *= 0.50;
                    }
                    else if (days >= 10)
                    {
                        price *= 0.65;
                    }
                    else if (days < 10)
                    {
                        price *= 0.70;
                    }
                    break;
                case "president apartment":
                    price = 235.0;
                    if (days > 15)
                    {
                        price *= 0.80;
                    }
                    else if (days >= 10)
                    {
                        price *= 0.85;
                    }
                    else if (days < 10)
                    {
                        price *= 0.90;
                    }
                    break;
                case "room for one person":
                    price = 118.0;
                    break;
                default:
                    break;
            }

            if (ass == "positive")
            {
                Console.WriteLine($"{(nights *price)*1.25:F2}");
            }
            else
            {
                Console.WriteLine($"{(nights * price) * 0.90:F2}");
            }
        }
    }
}