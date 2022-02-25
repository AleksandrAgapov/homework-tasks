

//38.	Найти сумму чисел одномерного массива стоящих на нечетной позиции
Console.Clear();
int[] array = new int[9];
int sumM = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(10, 99);
    System.Console.Write("|" + array[i] + "");
    System.Console.Write("|");

}
System.Console.WriteLine();

for (int i = 0; i < array.Length; i++)
    if (array[i] % 2 == 1)
    {
        sumM = sumM + array[i];
    }
System.Console.WriteLine("Сумма нечетных элементов массива равна " + sumM);

