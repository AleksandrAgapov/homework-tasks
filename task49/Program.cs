//49.	Показать двумерный массив размером m×n заполненный вещественными числами



double[,]nums = new double[3,5]; // создали двумерный массив

Random rand = new Random(); 

for( int i=0; i<nums.GetLength(0);i++) //  перебор строк в массиве
{   
    for( int j=0; j<nums.GetLength(1);j++)     // перебор столбцов в массиве
{     nums[i,j] = rand.NextDouble()*20;
    nums[i,j] = rand.NextDouble()*20; //  присваивание значения элементу массива

   
    System.Console.Write(nums[i,j] +"\t"); // отображение элемента в строке
}

    System.Console.WriteLine(); // переход к новой строке
}