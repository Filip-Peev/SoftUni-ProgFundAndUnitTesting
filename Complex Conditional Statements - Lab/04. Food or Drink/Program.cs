string product = Console.ReadLine();

if (product == "curry" || product == "noodles" || product == "sushi" || product == "spaghetti" || product == "bread")
{
    Console.WriteLine("food");
}
else if (product == "tea" || product == "water" || product == "coffee" || product == "juice" || product == "bread")
{
    Console.WriteLine("drink");
}
else {
    Console.WriteLine("unknown");
}