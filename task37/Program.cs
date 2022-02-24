//37.	В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

Console.Clear();
int[] array = new int[123];
int sumM = 0; 


for (int i = 10; i <= 99; i++)
{
    array[i] = new Random().Next(10, 99);
    System.Console.Write("|" + array[i] + "");
    System.Console.Write("|");
    
         sumM = sumM + 1;
 }
System.Console.WriteLine("  элементов в массиве на отрезке (10, 99)   {0}", sumM);




