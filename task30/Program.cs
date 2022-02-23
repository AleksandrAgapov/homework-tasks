//30.	Показать кубы чисел, заканчивающихся на четную цифру
int[] array = new int[5];
double a;
for(int i = 0; i<array.Length;i++)
{
     array[i]  = new Random().Next(2,8);
    if (array [i] %2==0)
        {
            a = Math.Pow(array[i],3);
        System.Console.WriteLine(" элемент массива {0} в кубе {1} заканчивается на четную цифру" ,i,a );
    }
}