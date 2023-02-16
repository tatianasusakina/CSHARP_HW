// Задача 6: Напишите программу, 
// которая на вход принимает число 
// и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).

//  4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число, для проверки (чётное или нечётное)");

int numberA = Convert.ToInt32(Console.ReadLine());
int index;

index = numberA % 2;

if (index == 0)
{
  Console.WriteLine("Да, число (" + numberA + ") - чётное!");
}
else
{
  Console.WriteLine("Нет, число " + numberA + " - нечётное!");
}
