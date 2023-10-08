string movieType = Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int seatsPerRow= int.Parse(Console.ReadLine());

if(movieType == "Premiere")
{
    Console.WriteLine($"{rows*seatsPerRow*12.00:F2}");
}
else if(movieType == "Normal")
{
    Console.WriteLine($"{rows * seatsPerRow * 7.50:F2}");
}
else if (movieType == "Discount")
{
    Console.WriteLine($"{rows * seatsPerRow * 5.0:F2}");
}