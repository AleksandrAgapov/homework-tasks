// показать числа Фибоначи

int []ArrayF = new int[15];
ArrayF[0]=1;
ArrayF[1]=1; 
int sumArray;

for( int i=2; i< ArrayF.Length; i++)
{
    ArrayF[i]=ArrayF[i-1]+ArrayF[i-2];
   
    System.Console.WriteLine("Число Фибоначи {0} равно {1}",i, ArrayF[i]);

}
 
