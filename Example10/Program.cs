// 10/
//Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа

using static System.Console;
Clear();

WriteLine("Введите трехзначное число");
int number = int.Parse(ReadLine());
if ((number >99) && (number <1000))
{
    int result = (number % 100)/10;
    WriteLine($"Вторая цифра числа {result}");
}
else
{
    WriteLine("Число не трехзначное");
}
