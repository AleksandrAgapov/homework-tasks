
//48.	Показать двумерный массив размером m×n заполненный целыми числами

// int[,] b=new int[3,2]{{1,2},{3,4},{5,6}};

// for(int i=0;i<3;i++)
// for(int j=0;j<2;j++)
// System.Console.WriteLine($"{i},{j}={b[i,j]}");
 int[,] b=new int[2,2]{{1,2},{3,4}};
void Print2D(int[,] b)
{
for(int i=0;i<b.GetLength(0);i++)
{
for(int j=0;j<b.GetLength(1);j++)
System.Console.Write($"{b[i,j],4}");
System.Console.WriteLine();
}
}

Print2D(b);
