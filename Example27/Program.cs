// 27
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

using static System.Console;
Clear();

WriteLine("Введите число");
WriteLine($"сумма всех чисел равна {GetSum(int.Parse(ReadLine()))}"); 
int GetSum(int number)
{
    int result = 0;
    while (number != 0)
    {
        result = result + (number%10);
        number = number/10;
    }

    return result;
}