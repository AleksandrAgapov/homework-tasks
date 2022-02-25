
// пример заполнения массива числами в арифметическом порядке

Console.Clear();
int[] array = new int[10];
int num =0;


for (int i = 0; i < array.Length; i++)
 {num = num+1;
 array[i]=num;
    System.Console.Write("|" + array[i] + "");
    System.Console.Write("|");

}
// System.Console.WriteLine();

// for (int i = 0; i < array.Length; i++)
//     if (array[i] % 2 == 1)
//     {
//         sumM = sumM + array[i];
//     }
// System.Console.WriteLine("Сумма нечетных элементов массива равна " + sumM);
