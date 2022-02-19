Console.Clear();
int x;
int y;
System.Console.WriteLine(" задайте кординату x  ");
x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(" залайте координату y");
y = Convert.ToInt32(Console.ReadLine());
if (x > 0 & y > 0)
{
    System.Console.WriteLine("Точка находится в I квадрате");
}
if (x < 0 & y > 0)
{
    System.Console.WriteLine("Точка находится в II квадрате");
}
if (x < 0 & y < 0)
{
    System.Console.WriteLine("Точка находится в III квадрате");
}
if (x > 0 & y < 0)
{
    System.Console.WriteLine("Точка находится в IV квадрате");
}

