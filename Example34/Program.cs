// 34: 
//Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
using static System.Console;
Clear();
int[] array = GetArray(9, 100, 1000);
WriteLine($"[{String.Join(",", array)}]");
int PositiveAmount = GetPositiveAmount(array);
WriteLine(PositiveAmount);
int GetPositiveAmount(int[] array)
{
    int result2 = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) result2++;
    }
    return result2;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue);
    }
    return result;
}
