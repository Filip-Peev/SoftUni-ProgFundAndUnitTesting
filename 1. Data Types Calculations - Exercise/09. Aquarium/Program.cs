namespace _09._Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int heigth = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double volume = length * width * heigth;
            double volumeInLiters = volume / 1000;

            percent = percent / 100;

            Console.WriteLine($"{volumeInLiters * (1 - percent):F2}");
        }
    }
}