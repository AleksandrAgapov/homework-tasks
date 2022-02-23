//33.	Задать массив из 12 элементов, заполненных числами из [-9, 9]. 
//Найти сумму положительных/отрицательных элементов массива

Console.Clear();
int[] array = new int[12];
int sumM = 0; // Сумма отрицательных элементов массива
int sumP = 0; // Сумма положительных элементов массива

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 9);
    System.Console.Write("|" + array[i] + "");
    System.Console.Write("|");
    if (array[i] < 0)

        sumM = sumM + array[i];
    else
        sumP = sumP + array[i];

}
System.Console.WriteLine("сумма отрицательных элементов массива {0}, сумма положительных {1}", sumM, sumP);









