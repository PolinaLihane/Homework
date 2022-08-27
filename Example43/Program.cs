// 43
// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

using static System.Console;
Clear();

WriteLine("Введите b1");
double b1 = int.Parse(ReadLine());
WriteLine("Введите k1");
double k1 = int.Parse(ReadLine());
WriteLine("Введите b2");
double b2 = int.Parse(ReadLine());
WriteLine("Введите k2");
double k2 = int.Parse(ReadLine());

double x = Getx(b1, k1, b2, k2);
double y = Gety(x, b2, k2);

WriteLine($"Точка пересечения({x},{y})");

double Getx(double b1, double k1, double b2, double k2)
{
    return (b2 - b1) / (k1 - k2);
}

double Gety(double x, double b2, double k2)
{
    return k2 * x + b2;
}