// Задача 8: Напишите программу, 
// которая на вход принимает число (N), 
// а на выходе показывает 
// все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число, для того чтобы определить все чётные числа от 1 до заданного числа");
Console.Write("Число - ");

int numberN = Convert.ToInt32(Console.ReadLine());
int size;
int index;

size = numberN + 1;
index = 0;

while (index < size)
{
  if (index % 2 == 0 && index != 0)
  {
    Console.Write(index + " ");
  }
  index = index + 1;
}
