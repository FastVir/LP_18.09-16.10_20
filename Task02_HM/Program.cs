// Задача 2: Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее.

// Пример
// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3

using System.ComponentModel.DataAnnotations;

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.Write($"Max = {number1}; Min = {number2}");
}
else if (number1 < number2)
{
    Console.Write($" Max = {number2}; Min = {number1}");
}
else Console.Write($"Первое и второе число равны Max = {number1}");