// 16.	Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.Clear();
int a;

System.Console.WriteLine(" введите число   от 1 до 7");
a = Convert.ToInt32(Console.ReadLine());


if (a == 1)
{
    System.Console.WriteLine("понедельник это рабочий день");
}
if (a == 2)
{
    System.Console.WriteLine("вторник это рабочий день");
}
if (a == 3)
{
    System.Console.WriteLine("среда это рабочий день");
}
if (a == 4)
{
    System.Console.WriteLine("четверг это рабочий день");
}
if (a == 5)
{
    System.Console.WriteLine("пятница это рабочий день");
}
if (a == 6)
{
    System.Console.WriteLine("Ура суббота выходной день");
}
if (a == 7)
{
    System.Console.WriteLine("Ура врскресенье выходной день");
}


