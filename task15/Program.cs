// 15.	Найти третью цифру числа или сообщить, что её нет
Console.Clear();
int a;
string s;

 System.Console.WriteLine("введите любое число");
 s = Console.ReadLine();
 a = Convert.ToInt32(s);
a = s.Length; // команда позволяющая вычислить количество знаков в цифре
if ( a>=3)
{
     System.Console.WriteLine($"Третья цифра числа:"   +s[2]); // прикрепляем знаком + номер индекса числа а
}
else 
 System.Console.WriteLine("В числе отсутствует третья цифра");