namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double sum = 0;

            if (type == "Premiere")
            {
                sum = rows * columns * 12.00;
            }
            else if (type == "Normal")
            {
                sum = rows * columns * 7.50;
            }
            else if (type == "Discount")
            {
                sum = rows * columns * 5.00;
            }

            Console.WriteLine($"{sum:F2} leva");
        }
    }
}