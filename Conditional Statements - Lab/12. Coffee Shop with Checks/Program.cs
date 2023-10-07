namespace _12._Coffee_Shop_with_Checks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                string order = Console.ReadLine();
                string extra = Console.ReadLine();
                double price = 0;
                if (order == "coffee" || order == "tea") 
                {
                    if (order == "coffee")
                        price = 1.00;
                    else if (order == "tea")
                        price = 0.60;
                }
                else
                {
                    Console.WriteLine("Unknown drink");
                    return;
                }
                if (extra == "sugar" || extra == "no") {

                    if (extra == "sugar")
                        price += 0.40;
                    Console.WriteLine("Final price: ${0:f2}", price);
                }
                else
                {
                    Console.WriteLine("Unknown extra");
                }                
            }
        }
    }
}