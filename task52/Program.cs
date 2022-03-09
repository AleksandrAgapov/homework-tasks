
//52.В двумерном массиве заменить элементы, у которых оба индекса чётные на  квадраты этих элементов

int[,]nums = new int[5,5];
int a =1; 

for( int i=0; i<nums.GetLength(0);i++) 
{
    for( int j=0; j<nums.GetLength(1);j++)     
{
    nums[i,j]= a;
    a++;
        
           System.Console.Write($"{nums[i,j],6}|"); 
}

    System.Console.WriteLine(); 
}
    System.Console.WriteLine();



    for( int i=0; i<nums.GetLength(0);i++) 
{
    for( int j=0; j<nums.GetLength(1);j++)     
{
       if(i%2==0 && j%2==0)

   nums[i,j]= (int) Math.Pow(nums[i,j],2);
    

    System.Console.Write($"{nums[i,j],6}|"); 
}
System.Console.WriteLine(); 
}
 System.Console.WriteLine();


