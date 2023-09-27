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

<<<<<<< HEAD
            if (fishermen <= 6) {
=======
            if (fishermen <= 6)
            {
>>>>>>> 9ee55e6943a4ef16fa7bbd5b6723c43fec114c55
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

<<<<<<< HEAD
            if (fishermen % 2 == 0 && season != "Autumn") {
=======
            if (fishermen % 2 == 0 && season != "Autumn")
            {
>>>>>>> 9ee55e6943a4ef16fa7bbd5b6723c43fec114c55
                sum *= 0.95;
            }
            if (budget >= sum)
            {
                Console.WriteLine($"Yes! You have {budget - sum:F2} leva left.");
            }
<<<<<<< HEAD
            else {
                Console.WriteLine($"Not enough money! You need {sum-budget:F2} leva.");
=======
            else
            {
                Console.WriteLine($"Not enough money! You need {sum - budget:F2} leva.");
>>>>>>> 9ee55e6943a4ef16fa7bbd5b6723c43fec114c55
            }
        }
    }
}