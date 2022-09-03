// 56:
//Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
using static System.Console;
Clear();
WriteLine("Введите параметры массива: ");
int[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
int[,] array = GetMatrix(parameters[0], parameters[1], parameters[2], parameters[3]);

if (parameters[0] == parameters[1])
{
    WriteLine("это не прямоугольный массив");
    return;
}
PrintMatrix(array);
WriteLine();
int[] rowArray = GetRowArray(array);
WriteLine(String.Join(" ", rowArray));
PrintMin(rowArray);

void PrintMin(int[] rowArray)
{
    int min=rowArray[0];
    int minIndex=0;
    for (int i = 0; i < rowArray.Length; i++)
    {
        if (min>rowArray[i])
        {
            min=rowArray[i];
            minIndex=i;
        }
    }
    WriteLine($"Строка с наименьшей суммой {minIndex+1}");
}

int[,] GetMatrix(int rows, int colums, int minValue, int maxValue)
{
    int[,] result = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}
void PrintMatrix(int[,] inArray) //печать масс
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}

int[] GetRowArray(int[,] inArray) //разворачиваем массив
{
    int[] result = new int[inArray.GetLength(0)];
    int k = 0;
    
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        int sum = inArray[i,0];
        for (int j = 1; j < inArray.GetLength(1); j++)
        {      
        sum += inArray[i,j];
        }
        result[k] = sum;
        k++;
    }
    return result;
}



