int n = int.Parse(Console.ReadLine());

Console.WriteLine(GetSignOfIntegerNumber(n));

static string GetSignOfIntegerNumber(int n)
{
    if (n > 0) return $"The number {n} is positive.";
    else if (n < 0) return $"The number {n} is negative.";
    else return $"The number {n} is zero.";
}