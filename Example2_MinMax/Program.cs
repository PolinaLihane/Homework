using static System.Console;
//Задача 2: Напишите программу, которая на вход принимает два числа 
//и выдаёт, какое число большее, а какое меньшее.
Clear();
WriteLine("Введите 2 числа: ");
int number1 = int.Parse(ReadLine());
int number2 = int.Parse(ReadLine());

if (number1>= number2) 
{
    WriteLine($"Наибольшее число: {number1} ; наименьшее число: {number2}");
}  
else   
{
    WriteLine($"Наибольшее число: {number2} ; наименьшее число: {number1}");
}  