// Задача 13: Напишите программу:
// 1. которая выводит третью цифру заданного числа 
// 2. или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100)
{
   string threeDigit = number.ToString(); // делаем преобразование числа в строку
   
   Console.Write(threeDigit[2]);
}
else Console.Write($"В введеном числе {number} меньше 3-х цифр");
