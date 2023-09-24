namespace _02._Summer_Clothing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            string clothing = "";
            string shoes = "";

            if (temp >= 10 && temp <= 18)
            {
                switch (time)
                {
                    case "Morning":
                        clothing = "Sweatshirt";
                        shoes = "Sneakers";
                        break;
                    case "Afternoon":
                    case "Evening":
                        clothing = "Shirt";
                        shoes = "Moccasins";
                        break;
                    default: break;
                }
            }
            else if (temp > 18 && temp <= 24)
            {
                switch (time)
                {
                    case "Morning":
                    case "Evening":
                        clothing = "Shirt";
                        shoes = "Moccasins";
                        break;
                    case "Afternoon":
                        clothing = "T-Shirt";
                        shoes = "Sandals";
                        break;

                    default: break;
                }
            }
            else if (temp >= 25)
            {
                switch (time)
                {
                    case "Morning":
                        clothing = "T-Shirt";
                        shoes = "Sandals";
                        break;
                    case "Afternoon":
                        clothing = "Swim Suit";
                        shoes = "Barefoot";
                        break;
                    case "Evening":
                        clothing = "Shirt";
                        shoes = "Moccasins";
                        break;
                    default: break;
                }
            }
            Console.WriteLine($"It's {temp} degrees, get your {clothing} and {shoes}.");
        }
    }
}