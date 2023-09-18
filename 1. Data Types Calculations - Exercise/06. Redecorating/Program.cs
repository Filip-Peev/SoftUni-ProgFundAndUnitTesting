namespace _06._Redecorating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            nylon += 2;
            double paint = double.Parse(Console.ReadLine());
            paint = paint + (paint * 0.10);
            int thinner = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double sumOfMaterials = nylon * 1.50 + paint * 14.50 + thinner * 5.00 + 0.40;
            double craftsmen = sumOfMaterials * (30 / 100.0) * hours;
            double finalSum = sumOfMaterials + craftsmen;

            Console.WriteLine(finalSum);
        }
    }
}