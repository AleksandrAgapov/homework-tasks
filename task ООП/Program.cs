/* Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел.
Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать
программу, демонстрирующую все разработанные элементы класса. Достаточно решить 2
задачи. Все программы сделайть в одном решении.*/


class Fraction // описываем класс дробей
{
    int numer, denumer;

     public Fraction(int numer, int denumer) // описываем некий конструктор
     {
         this.numer = numer;
         this.denumer = denumer;
             }
public Fraction  Plus(Fraction other) // метод сложения двух чисел
{
    Fraction result;
    result = new Fraction(this.numer*other.denumer+other.numer*this.denumer, this.denumer*other.denumer);
    return result;
}
public override string ToString() // метод представления нашей дроби в строчку через знак деления
{
    return $"{numer}/{denumer}";
}

}

class Program
{
   static void Main()
   {
       Fraction A =new Fraction (1,2);
       Fraction B = new Fraction(2,3);
       Fraction C = new Fraction(3,4);
       System.Console.WriteLine(A);
       System.Console.WriteLine(B);
       System.Console.WriteLine(C);
       A=A.Plus(B);
       System.Console.WriteLine(A);
   } 

}
