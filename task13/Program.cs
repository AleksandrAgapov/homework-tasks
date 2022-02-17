// 13. Удалить вторую цифру трехзначного сила

int a, b, c,d,k;
string s;
 System.Console.WriteLine("введите трехзначное число");
 s = Console.ReadLine();
 a = Convert.ToInt32(s);
 b= a%10;
 c=b%10;
 d=a/100;
 k = (d*10)+b;
 System.Console.WriteLine(k);

