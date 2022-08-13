// 15.
//Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

using static System.Console;
Clear();

WriteLine("Введите цифру, обозначающую день недели");
int number = int.Parse(ReadLine());

WriteLine("Этот день выходной?");

if (number>=1 && number<=5)
{
    WriteLine("Нет");
}
if (number>=6 && number <=7)
{
    WriteLine("Да");
}
if (number < 1 || number > 7)
{
    WriteLine("Ошибка");
}