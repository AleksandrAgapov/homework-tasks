//24.	найти кубы чисел от 1 до N


Console.Clear();
int a;
string b;
System.Console.WriteLine(" Введите число");
b = Console.ReadLine();
a = Convert.ToInt32(b);
for (int j = 1; j <= a; j++)
{
    System.Console.Write(j * j * j + " ");
}
