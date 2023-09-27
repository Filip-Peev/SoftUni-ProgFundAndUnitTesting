using System.Diagnostics.CodeAnalysis;

namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());

            double sum = 0;

            switch (season)
            {
                case "Spring":
                    sum = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    sum = 4200;
                    break;
                case "Winter":
                    sum = 2600;
                    break;
                default: break;
            }

            if (fishermen <= 6) {
                sum *= 0.90;
            }
            else if (fishermen <= 11)
            {
                sum *= 0.85;
            }
            else if (fishermen >= 12)
            {
                sum *= 0.75;
            }

            if (fishermen % 2 == 0 && season != "Autumn") {
                sum *= 0.95;
            }
            if (budget >= sum)
            {
                Console.WriteLine($"Yes! You have {budget - sum:F2} leva left.");
            }
            else {
                Console.WriteLine($"Not enough money! You need {sum-budget:F2} leva.");
            }
        }
    }
}