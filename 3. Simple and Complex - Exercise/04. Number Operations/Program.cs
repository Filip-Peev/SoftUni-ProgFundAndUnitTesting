double num1 = double.Parse(Console.ReadLine());
double num2 = double.Parse(Console.ReadLine());
char symbol = char.Parse(Console.ReadLine());

if (symbol == '+') {

    Console.WriteLine($"{num1} {symbol} {num2} = {num1 + num2:F2}");
}
else if (symbol == '-')
{
    Console.WriteLine($"{num1} {symbol} {num2} = {num1 - num2:F2}");
}
else if (symbol == '*')
{
    Console.WriteLine($"{num1} {symbol} {num2} = {num1 * num2:F2}");
}
else if (symbol == '/')
{
    Console.WriteLine($"{num1} {symbol} {num2} = {num1 / num2:F2}");
}