namespace _07._Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chicken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());
            int veg = int.Parse(Console.ReadLine());

            double sum = chicken * 10.35 + fish * 12.40 + veg * 8.15;
            double desert = sum * 0.2;
            double finalSum = sum + desert + 2.50;
            Console.WriteLine(finalSum);
        }
    }
}