// 9. Напишите программу:
// 1. которая выводит случайное число из отрезка [10, 99]
// 2.  и показывает наибольшую цифру числа.

// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100); // Max = 99 + 1
Console.WriteLine($"случайное число из отрезка [10, 99] -> {number}");

int firstDigit = number / 10; //78 / 10 = 7
int secondDigit = number % 10;

if (firstDigit > secondDigit)
{
    Console.Write(firstDigit);
}
else Console.Write(secondDigit);