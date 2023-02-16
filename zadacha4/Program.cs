// Задача 4: Напишите программу, 
// которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите три любых числа, для поиска среди них максимального");

Console.Write("Первое число - ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Второе число - ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.Write("Третье число - ");
int numberC = Convert.ToInt32(Console.ReadLine());


int max;
max = numberA;

if (numberB > max)
{
  max = numberB;
}
if (numberC > max)
{
  max = numberC;
}
Console.WriteLine("max = " + max);
