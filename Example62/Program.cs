// Задача 62. 
//Напишите программу, которая заполнит спирально массив 4 на 4.

using static System.Console;
Clear();
int[,] array = GetMatrix(4);
PrintMatrix(array);

int[,] GetMatrix(int size)
{
    int[,] result = new int[size, size];
    int count = 1;
   
        for (int i = 1; i <= size / 2; i++)
        {
            for (int j = i - 1; j < size - i + 1; j++)
            {
                result[i - 1, j] = count++;
            }
            for (int j = i; j < size - i + 1; j++)
            {
                result[j, size - i] = count++;
            }
            for (int j = size - i - 1; j >= i - 1; --j)
            {
                result[size - i, j] = count++;
            }
            for (int j = size - i - 1; j >= i; j--)
            {
                result[j, i - 1] = count++;
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

