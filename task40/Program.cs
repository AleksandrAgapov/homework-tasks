//40.	В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом


Console.Clear();
double[] array = new double[10];
double max = 0;
double min = 98;
double num;
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.NextDouble();
    System.Console.Write("|" + array[i] + "");
    System.Console.Write("|");
}
System.Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    if (max < array[i])
        max = array[i];

    if (min > array[i])

        min = array[i];
}
num = max - min;

System.Console.WriteLine($" Максимальный элемент массива = " + max);

System.Console.WriteLine(" Минимальный элемент массива = " + min);
System.Console.WriteLine(" max-min  = {0} ", num);



