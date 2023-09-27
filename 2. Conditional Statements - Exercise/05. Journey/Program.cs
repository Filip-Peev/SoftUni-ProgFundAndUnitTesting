namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string location = "";
            string country = "";

<<<<<<< HEAD

=======
>>>>>>> 9ee55e6943a4ef16fa7bbd5b6723c43fec114c55
            if (season == "summer")
            {
                location = "Camp";
            }
            else if (season == "winter")
            {
                location = "Hotel";
            }

            if (budget <= 100)
            {
                country = "Bulgaria";
                if (season == "summer")
                {
                    budget *= 0.30;
                }
                else if (season == "winter")
                {
                    budget *= 0.70;
                }
            }
            else if (budget <= 1000)
            {
                country = "Balkans";
                if (season == "summer")
                {
                    budget *= 0.40;
                }
                else if (season == "winter")
                {
                    budget *= 0.80;
                }
            }
            else if (budget > 1000)
            {
                country = "Europe";
                location = "Hotel";
                budget *= 0.90;
            }
            Console.WriteLine($"Somewhere in {country}");
            Console.WriteLine($"{location} - {budget:F2}");
        }
    }
}