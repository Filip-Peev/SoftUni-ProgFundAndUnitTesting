int num = int.Parse(Console.ReadLine());
int i = 1;
Console.WriteLine(1);
while (i < num)
{
    i = i * 2 + 1;
    if (i < num)
    {
        Console.WriteLine(i);
    }
}