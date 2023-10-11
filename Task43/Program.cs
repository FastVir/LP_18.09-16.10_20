// Задача 43: Напишите программу:
// которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, 
// y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
//
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



int PointOfIntersectionOfTwoLines(int b1, int k1, int b2, int k2)
{
    int x = (b2 - b1) / (k1 - k2);
    double xd = Convert.ToDouble(x);
    return xd;
}


Console.WriteLine("Введитете значение точки: ");
Console.Write("b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введитете значение точки: ");
Console.Write("k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введитете значение точки: ");
Console.Write("b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введитете значение точки: ");
Console.Write("k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
double point = PointOfIntersectionOfTwoLines(b1, k1, b2, k2);
Console.WriteLine($"Точка пересечения двух прямых ({point} ; {point})");