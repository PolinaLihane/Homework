//Задача 54: 
//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

using static System.Console;
Clear();
WriteLine("Введите параметры массива: ");
int[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
int[,] array = GetMatrix(parameters[0], parameters[1], parameters[2], parameters[3]);

PrintMatrix(array);
WriteLine();
SortMatrix(array);
PrintMatrix(array);


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


void SortMatrix(int[,] inArray) //пузырьковая сортировка от мин к макс
{

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++) //i+1 берем следующий эл тут
        {
            for (int k = j + 1; k < inArray.GetLength(1); k++)
            {
                int maxSum=inArray[0,j];
                if (inArray[i, j] < inArray[i, k]) //если предыдущий больше,то меняем местами.
                {
                    int temp = inArray[i, j];
                    inArray[i, j] = inArray[i, k];
                    inArray[i, k] = temp;
                }
            }
        }
    }
}