
int number = int.Parse(Console.ReadLine());

while (true)
{
    string command = Console.ReadLine();
    switch (command.ToLower())
    {
        case "inc":
            number++;
            break;
        case "dec":
            number--;
            break;
        case "end":
            Console.WriteLine(number);
            return;
        default:
            break;
    }
}