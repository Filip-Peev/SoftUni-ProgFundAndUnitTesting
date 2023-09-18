namespace _08._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int fee = int.Parse(Console.ReadLine());

            double sneakers = fee * 0.60;
            double team = sneakers * 0.80;
            double basketball = team * 0.25;
            double accessories = basketball * 0.20;

            double finalSum = fee + sneakers+team+basketball+accessories;

            Console.WriteLine(finalSum);
        }
    }
}