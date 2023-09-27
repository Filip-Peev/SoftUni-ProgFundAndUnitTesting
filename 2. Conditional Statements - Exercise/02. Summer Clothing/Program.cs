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
<<<<<<< HEAD
                        //clothing = "Shirt";
                        //shoes = "Moccasins";
                        //break;
=======
>>>>>>> 9ee55e6943a4ef16fa7bbd5b6723c43fec114c55
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
<<<<<<< HEAD
                        //clothing = "Shirt";
                        //shoes = "Moccasins";
                        //break;
=======
>>>>>>> 9ee55e6943a4ef16fa7bbd5b6723c43fec114c55
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
<<<<<<< HEAD
            else if (temp >=25)
=======
            else if (temp >= 25)
>>>>>>> 9ee55e6943a4ef16fa7bbd5b6723c43fec114c55
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