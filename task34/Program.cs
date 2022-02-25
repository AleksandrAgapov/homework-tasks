//34.	Написать программу замену элементов массива на противоположные


Console.Clear();
int[] array = new int[10];
int sumM = 0; 

for (int i = 0; i <array.Length; i++)
{
    array[i] = new Random().Next(-5, 5);
    System.Console.Write("|" + array[i] + "");
    System.Console.Write("|");
    
}
System.Console.WriteLine();

for (int i = 0; i <array.Length; i++)
{    
     sumM = array[i]*(-1);
    
     System.Console.Write("|" + sumM + "");
    System.Console.Write("|");
    }
    