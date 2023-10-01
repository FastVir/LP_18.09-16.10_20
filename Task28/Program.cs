// Задача 28: Напишите программу:
// 1. которая принимает на вход число N
// 2. и выдаёт произведение чисел от 1 до N.

// 4 -> 24
// 5 -> 120

int Factorial(int num)
{
    int fact = 1;
    for (int i = 1 ; i <= num; i++)    
    {
        checked
        {
            fact = fact * i;
        } 
    }
    return fact;
}

Console.WriteLine("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int factorial = Factorial(number);
Console.WriteLine(factorial);