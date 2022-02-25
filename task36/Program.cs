//36.	Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

Console.Clear();
int[] array = new int[25];
int sumM = 0; // количество четных
int sumP = 0; //количество не четных


for (int i = 0; i <array.Length; i++)
{
    array[i] = new Random().Next(100, 999);
    System.Console.Write("|" + array[i] + "");
    System.Console.Write("|");
    
}
for (int i = 0; i <array.Length; i++)
{
    if(array[i]%2==0)
     sumM = sumM+1;
    }
    System.Console.WriteLine();
    System.Console.WriteLine("Количество четных " +sumM);
        
        for (int i = 0; i <array.Length; i++)
        {
            if(array[i]%2==1)
            sumP = sumP+1;
        }
System.Console.WriteLine("Количество нечетных " +sumP);
   