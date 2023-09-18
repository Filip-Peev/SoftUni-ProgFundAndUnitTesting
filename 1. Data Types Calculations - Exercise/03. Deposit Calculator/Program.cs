namespace _03._Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositAmount = double.Parse(Console.ReadLine());
            int months= int.Parse(Console.ReadLine());
            double annualInterestRate= double.Parse(Console.ReadLine());

            double perMonth = (depositAmount*(annualInterestRate/100))/12;       
            double finalSum = depositAmount + (perMonth * months);
            Console.WriteLine(finalSum);
        }
    }
}