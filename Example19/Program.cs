// 19.
//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.

using static System.Console;
Clear();

WriteLine("Введите пятизначное число");
int Number = int.Parse(ReadLine());

if (Number>9999 && Number<100000)
{
if ((Number%10 == Number%100000/10000) && (Number%100/10 == Number%10000/1000))
{
    WriteLine("да");
}
else
{
    WriteLine("нет");
}
}