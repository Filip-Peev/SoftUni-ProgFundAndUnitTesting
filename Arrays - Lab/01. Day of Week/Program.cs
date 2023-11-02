int n = int.Parse(Console.ReadLine());

string[] weekDay = {
    "Monday",
    "Tuesday",
    "Wednesday",
    "Thursday",
    "Friday",
    "Saturday",
    "Sunday"
};
if (n >= 1 && n <= 7)
{
    Console.WriteLine(weekDay[n-1]);
}
else
{
    Console.WriteLine("Invalid day!");
}