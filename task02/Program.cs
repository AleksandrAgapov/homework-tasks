
	// 2. По двум заданным числам проверять является ли первое квадратом второго


int a=36;
int b=6;
// int square = b*b;

int square = (int)Math.Pow(b,2);

if (square==a)

  Console.WriteLine(" a  является квадратом b");

  else Console.WriteLine( " a не является квадратом b");
