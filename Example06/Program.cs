using static System.Console;
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// ли число чётным (делится ли оно на два без остатка).
WriteLine("Введите число: ");
int number = int.Parse(ReadLine());
if (number % 2 == 0)
{
    WriteLine($"{number} четное");
}
else 
{
    WriteLine($"{number} не четное");
}
