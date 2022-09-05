//Задача 64: 
//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N по убыванию.

using static System.Console;
Clear();
WriteLine("Введите первое число");
int m = int.Parse(ReadLine());
WriteLine("Введите второе число");
int n = int.Parse(ReadLine());
WriteLine(GetStringNumbers(m,n));

string GetStringNumbers(int m1, int n1)
{
    return (n1 == m1)?$"{m1}":m1<n1?$"{GetStringNumbers(m1+1,n1)} {m1}":$"{n1}"+GetStringNumbers(n1+1,m1);
}

