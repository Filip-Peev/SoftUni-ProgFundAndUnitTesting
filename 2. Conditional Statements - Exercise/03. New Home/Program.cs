using System.Diagnostics.CodeAnalysis;

namespace _03._New_Home
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double sum = 0;

            if (type == "Roses")
            {
                sum = count * 5.0;
                if (count > 80)
                {
                    sum *= 0.90;
                }
            }
            else if (type == "Dahlias")
            {
                sum = count * 3.80;
                if (count > 90)
                {
                    sum *= 0.85;
                }
            }
            else if (type == "Tulips")
            {
                sum = count * 2.80;
                if (count > 80)
                {
                    sum *= 0.85;
                }
            }
            else if (type == "Narcissus")
            {
                sum = count * 3.0;
                if (count < 120)
                {
                    sum *= 1.15;
                }
            }
            else if (type == "Gladiolus")
            {
                sum = count * 2.50;
                if (count < 80)
                {
                    sum *= 1.20;
                }
            }

            if (sum <= budget)
<<<<<<< HEAD
                Console.WriteLine($"Hey, you have a great garden with {count} {type} and {budget-sum:F2} leva left.");
=======
                Console.WriteLine($"Hey, you have a great garden with {count} {type} and {budget - sum:F2} leva left.");
>>>>>>> 9ee55e6943a4ef16fa7bbd5b6723c43fec114c55
            else
            {
                Console.WriteLine($"Not enough money, you need {sum - budget:F2} leva more.");
            }
        }
    }
}