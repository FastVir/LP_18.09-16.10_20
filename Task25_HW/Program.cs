// Задача 25: Напишите цикл:
// 1. который принимает на вход два числа (A и B) 
// 2. и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Exponentiation(int a, int b)
{
    if (b < 0) b = b * -1;
    int exp = a;
    for (int i = 1; i < b; i++)
    {
        exp = exp * a;
    }
    return exp;
}


Console.WriteLine("Введите первое число: ");
Console.Write("A: ");
int firstDigit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
Console.Write("B: ");
int secondDigit = Convert.ToInt32(Console.ReadLine());


int exponentiation = Exponentiation(firstDigit, secondDigit);
Console.WriteLine($"Степень {firstDigit} от {secondDigit} равна {exponentiation}");

System.Threading.Thread.Sleep(2000);
Console.Clear();