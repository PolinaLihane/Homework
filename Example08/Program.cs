using static System.Console;
// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
Clear();
WriteLine("Введите число: ");
int N = int.Parse(ReadLine());
int i = 1;
while (i<=N)
{
    if (i % 2 ==0)
    Write($"{i}, ");
    i++;
}

