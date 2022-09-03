//Задача 58: 
//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

using static System.Console;
Clear();
int[,] array = GetMatrix(2,2,0,100);
int[,] arrayTwo = GetMatrix(2,2,0,100);
  if (array.GetLength(1) != arrayTwo.GetLength(0))
{
    WriteLine("Нельзя посчитать произведение");
    return;
}
PrintMatrix(array);
WriteLine();
PrintMatrix(arrayTwo);
WriteLine();
int[,] SumMat = SumMatrix(array, arrayTwo);
PrintMatrix(SumMat);

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

int[,] SumMatrix(int[,] inArray, int[,] inArrayTwo)
{
  
    int[,] sumArray = new int[inArray.GetLength(1), inArray.GetLength(0)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(0); k++)
            {
                sumArray[i, j] += inArray[i, k] * inArrayTwo[k, j];
            }
        }
    }
    return sumArray;
}


