//50.	В двумерном массиве n×k заменить четные элементы на противоположные

int[,]nums = new int[5,4]; // создали двумерный массив

for( int i=0; i<nums.GetLength(0);i++) //  перебор строк в массиве
{
    for( int j=0; j<nums.GetLength(1);j++)     // перебор столбцов в массиве
{
    nums[i,j]= new Random().Next(1,10);

        System.Console.Write($"{nums[i,j],6}|"); // отображение элемента в строке
}

    System.Console.WriteLine(); // переход к новой строке
}
    System.Console.WriteLine();

for( int i=0; i<nums.GetLength(0);i++) //  перебор строк в массиве
{
    for( int j=0; j<nums.GetLength(1);j++)     // перебор столбцов в массиве
{
       if (nums[i,j]%2==0)
    
    nums[i,j]=nums[i,j]*(-1);
    
    else
    
      nums[i,j]=nums[i,j];  
    
    System.Console.Write($"{nums[i,j],6}|");
    }
    System.Console.WriteLine();
}
