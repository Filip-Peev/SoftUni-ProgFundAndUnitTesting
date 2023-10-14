int size = int.Parse(Console.ReadLine());

for (int row = 1; row <= size; row++)
{
    string line = new string('*', row);
    Console.WriteLine(line);
}