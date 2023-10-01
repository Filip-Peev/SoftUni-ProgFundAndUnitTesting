namespace _09._Sum_Seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int time = first + second + third;

            int minutes = 0;
            int seconds = 0;

            if (time > 59)
            {
                minutes = time / 60;
                seconds = time % 60;
                Console.WriteLine($"{minutes}:{seconds:D2}");
            }
            else
            {
                Console.WriteLine($"0:{time:D2}");
            }
        }
    }
}