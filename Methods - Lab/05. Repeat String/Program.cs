using System.Text;

string txt = Console.ReadLine();
int count = int.Parse(Console.ReadLine());

Console.WriteLine(RepeatString(txt, count));

static string RepeatString(string? txt, int count)
{
    StringBuilder sb = new StringBuilder();
    for (int i = 0; i < count; i++) sb.Append(txt);
    return sb.ToString();
}