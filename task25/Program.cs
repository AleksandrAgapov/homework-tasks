//25.	Найти сумму чисел от 1 до N



Console.Clear();
int n ;
int i = 1;
int sum = 0;
string b;
System.Console.WriteLine(" Введите число n");
b = Console.ReadLine();
n = Convert.ToInt32(b);
while (i <= n)
{
    System.Console.WriteLine ( i );
    sum = sum + i;
    i++;

}
System.Console.WriteLine("Сумма чисел от 1 до {0} равна = {1} ", n, sum);



