// 15: Напишите программу:
// 1.  которая принимает на вход цифру, обозначающую день недели,
// 2.  и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Ввведите число: ");
int dayWeek = Convert.ToInt32(Console.ReadLine());

if (dayWeek == 6 || dayWeek == 7)
{
    Console.Write($"{dayWeek} -> выходной");
}
else if (dayWeek>= 1 && dayWeek <= 5)
{
    Console.Write($"{dayWeek} -> не выходной");
}
else Console.Write("Такого дня недели не существует");