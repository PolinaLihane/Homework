//  23
//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.

using static System.Console;
Clear();

WriteLine("Введите число");
int N = int.Parse(ReadLine());

for (int i=1; i<=N; i++)
{
    WriteLine($"{i}^3={i*i*i}");
}