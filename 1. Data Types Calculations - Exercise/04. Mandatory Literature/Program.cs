namespace _04._Mandatory_Literature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int numberOfDays = int.Parse(Console.ReadLine());

            int hoursToRead = numberOfPages / pagesPerHour;
            int hoursPerDay = hoursToRead / numberOfDays;
            Console.WriteLine(hoursPerDay);
        }
    }
}