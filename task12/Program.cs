//12.	Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

Console.Clear();

int с = 0;
int max = 0;
{
    {
int a = new Random().Next(10, 99);
System.Console.WriteLine($"выбираем случайное число", a);

System.Console.WriteLine(a);



int c = a / 10;

int b = a % 10;


System.Console.WriteLine( $"первая цифра {c}");
System.Console.WriteLine($"вторая цифра {b}");
 
if (c==b)
    
 if (b > с)     
 max = b;
 if (c > b)
 max = c;
     System.Console.WriteLine($"наибольшая цифра числа {max}");
}
}
//     else
    
//     System.Console.WriteLine($"{b} равно {с}");
// }
// }


 
