//15_2	Дано число. Проверить кратно ли оно 7 и 23

Console.Clear();
double a;
double summ1;
double summ2;
string s1, s2;
System.Console.WriteLine(" введите число  ");
a = Convert.ToDouble(Console.ReadLine());
summ1 = a % 7;
summ2 = a % 23;

s1 = (summ1 == 0 ? "число  кратно 7" : " число не кратно 7");
s2 = (summ2 == 0 ? "число  кратно 23" : " число не кратно 23");

System.Console.WriteLine("{0}, {1}", s1, s2);


