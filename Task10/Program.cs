// Задача 10: Напишите программу:
//  1. которая принимает на вход трёхзначное число 
//  2. и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 999 && number >=100)
{
    int doubleDigit = number / 10;
    int secondDigit = doubleDigit % 10;
    Console.Write($"Вторая цифра введенного числа {secondDigit}");
    
}
else Console.Write("Введено не верное значение");