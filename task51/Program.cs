
//51.	Задать двумерный массив следующим правилом: Aₘₙ = m+n

int[,]nums = new int[5,5]; 

for( int i=0; i<nums.GetLength(0);i++) 
{
    for( int j=0; j<nums.GetLength(1);j++)     
{
    nums[i,j]= i+j;

        System.Console.Write($"{nums[i,j],6}|"); 
}

    System.Console.WriteLine(); 
}
    System.Console.WriteLine();

