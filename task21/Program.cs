
//21.	Программа проверяет пятизначное число на палиндромом.

Console.Clear();
int x;
int a1;
int a2;
int a3;
int a4;
int a5;

int z;
System.Console.WriteLine(" Задайте пятизначное число ");
x = Convert.ToInt32(Console.ReadLine());

a1=x%10;
a2=(x/10)%10;
a3=(x/100)%10;
a4=(x/1000)%10;
a5=(x/10000)%10;
System.Console.WriteLine("{0} {1} {2} {3} {4}",  a1,a2,a3,a4,a5);
z =(a1*10000)+(a2*1000)+(a3*100)+(a4*10)+a5;

if(z==x)
{
    System.Console.WriteLine("введенное число палиндром");
    
}
if(z!=x)
{
    System.Console.WriteLine("введенное число не палиндром");
}