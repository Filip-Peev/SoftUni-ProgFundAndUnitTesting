namespace _05._Teaching_Materials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int cleaner = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double sumOfItems = (pens * 5.80) + (markers * 7.20) + (cleaner * 1.20);
            Console.WriteLine(sumOfItems - (sumOfItems * discount / 100.0));
        }
    }
}