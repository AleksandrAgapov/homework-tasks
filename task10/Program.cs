// 10.	Показать последнюю цифру трёхзначного числа

int a = 0; // задаем переменную
string s = string.Empty; // зададим пустую строку

System.Console.Write("Введите трехзначное число ");
s = Console.ReadLine(); // положим введенное число в нашу строку
a = s.Length; // подсчитаем длину строки



if(a == 3) System.Console.WriteLine( "Третья цифра трехзначного числа "  +s[s.Length^1]);
else System.Console.WriteLine("Число не является трехзначным");