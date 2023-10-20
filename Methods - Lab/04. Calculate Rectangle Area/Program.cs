int w = int.Parse(Console.ReadLine());
int h = int.Parse(Console.ReadLine());

CalculateRectangleArea(w, h);

static void CalculateRectangleArea(int w, int h)
{
    Console.WriteLine(w * h);
}