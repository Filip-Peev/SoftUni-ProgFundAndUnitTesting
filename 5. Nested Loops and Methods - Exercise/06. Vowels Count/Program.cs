string text = Console.ReadLine();

Console.WriteLine(GetVowelsCount(text));
static int GetVowelsCount(string text)
{
    int count = 0;
    for (int position = 0; position <= text.Length - 1; position++)
    {
        char symbol = text[position];
        if (symbol == 'a' || symbol == 'A' ||
            symbol == 'e' || symbol == 'E' ||
            symbol == 'i' || symbol == 'I' ||
            symbol == 'o' || symbol == 'O' ||
            symbol == 'u' || symbol == 'U')
        {
            count++;
        }
    }
    return count;
}