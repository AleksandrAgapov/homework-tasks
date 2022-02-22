//26.	Возведите число А в натуральную степень B используя цикл

Console.Clear();
int n; ///степень
int num; // число
int rezult = 1; 
string b,a;
System.Console.WriteLine(" Введите число которое возводим в степень");
b = Console.ReadLine();
num = Convert.ToInt32(b);
System.Console.WriteLine(" Введите  степень числа n");
a = Console.ReadLine();
n = Convert.ToInt32(a);


for (int i=0;i<n; i++)
{
 rezult = rezult*num;
     
}
System.Console.WriteLine(" Число {0} в степени {1}  = {2}", num,n,rezult);



