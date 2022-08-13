// 13.
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет

using static System.Console;
Clear();

WriteLine("Введите число");
int number = int.Parse(ReadLine());

if ( number > 99 || number< -99)
{
int result = ( number % 1000) / 100;
 WriteLine($"Третья цифра числа {result}");
 }
else
{
    WriteLine("Нет третьей цифры числа");
}