//39.	Найти произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.

Console.Clear();
int[] array = new int[10];
int sumM = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
    System.Console.Write("|" + array[i] + "");
    System.Console.Write("|");

}
System.Console.WriteLine();

for (int i = 0; i < array.Length / 2; i++)
{
    sumM = array[i] * array[array.Length - 1 - i];
    System.Console.WriteLine("произведение {0} элемента и  {1} равно {2} ", i, array.Length - 1 - i, sumM);

}
