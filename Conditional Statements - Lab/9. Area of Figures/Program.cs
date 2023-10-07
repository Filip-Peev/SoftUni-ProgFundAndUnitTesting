namespace _9._Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                var area = a * a;
                Console.WriteLine($"{area:F2}");
            }
            else if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                var area = a * b;
                Console.WriteLine($"{area:F2}");
            }
            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                var area = Math.PI * r * r;
                Console.WriteLine($"{area:F2}");
            }
            else 
            {
                Console.WriteLine("Invalid figure.");
            }
        }
    }
}