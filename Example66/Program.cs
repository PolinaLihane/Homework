// Задача 66:
// Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
using static System.Console;
Clear();
WriteLine("Введите первое число");
int m = int.Parse(ReadLine());
WriteLine("Введите второе число");
int n = int.Parse(ReadLine());
WriteLine(GetSum(m, n));

int GetSum(int m1, int n1)
{
    return (n1 >= m1) ? n1 + GetSum(m1, n1 - 1) : 0;
}

