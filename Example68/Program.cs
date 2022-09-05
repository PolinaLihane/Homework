// Задача 68: 
//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
using static System.Console;
Clear();
WriteLine("Введите первое число");
int m = int.Parse(ReadLine());
WriteLine("Введите второе число");
int n = int.Parse(ReadLine());
WriteLine(Ackermann(m, n));

int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ackermann(m - 1, 1);
    else return Ackermann(m - 1, Ackermann(m, n - 1));
}
