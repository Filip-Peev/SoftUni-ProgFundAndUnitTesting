string season  = Console.ReadLine();
string acc  = Console.ReadLine();
double days = Double.Parse(Console.ReadLine());

double price = 0.0;

if (season == "Spring")
{
    if (acc == "Hotel")
    {
        price = (30 * days) * 0.80;
    }
    else if (acc == "Camping")
    {
        price = (10 * days) * 0.80;
    }
}
else if (season == "Summer")
{
    if (acc == "Hotel")
    {
        price = (50 * days) * 1.0;
    }
    else if (acc == "Camping")
    {
        price = (30 * days) * 1.0;
    }
}
else if (season == "Autumn")
{
    if (acc == "Hotel")
    {
        price = (20 * days) * 0.70;
    }
    else if (acc == "Camping")
    {
        price = (15 * days) * 0.70;
    }
}
else if (season == "Winter")
{
    if (acc == "Hotel")
    {
        price = (40 * days) * 0.90;
    }
    else if (acc == "Camping")
    {
        price = (10 * days) * 0.90;
    }
}
Console.WriteLine($"{price:F2}");