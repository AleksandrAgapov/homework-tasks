// 	28.	Подсчитать сумму цифр в числе

Console.Clear();
int num;
int a = 0; // сумма цифр
int c =0;  // отделяемая цифра 
int b;    // переменная для остановки цикла 
string d;
System.Console.WriteLine(" Введите число  в котором считем сумму цифр");
d = Console.ReadLine();
num = Convert.ToInt32(d);
while (num>0)
{
c=num%10;
a=a+c;
num=num/10;
}
System.Console.WriteLine("сумма цифр в веденном числе = {0}", a);