//  47. 
//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

using static System.Console;
Clear();

WriteLine("Введите размер массива m и n");
int m = int.Parse(ReadLine());
int n = int.Parse(ReadLine());
double[,] matrix = GetMatrixArray(m, n);
PrintMatrixArray(matrix);

double[,] GetMatrixArray(int m, int n)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = Convert.ToDouble(new Random().Next(-100, 100));//
        }
    }
    return result;
}

void PrintMatrixArray(double[,] inArray)
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