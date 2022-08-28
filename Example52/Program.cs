// 52. 
//Задайте двумерный массив из целых чисел. 
//Найдите  среднее арифметическое элементов в каждом столбце.


using static System.Console;
Clear();

WriteLine("Введите размер массива m и n");
int m = int.Parse(ReadLine());
int n = int.Parse(ReadLine());
int[,] matrix = GetMatrixArray(m, n);
PrintMatrix(matrix);
GetAverage(matrix);

int[,] GetMatrixArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1, 10);//
        }
    }
    return result;
}

void PrintMatrix(int[,] inArray)
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
void GetAverage(int[,] matrix)
{
    Write("Среднее арифметическое каждого столбца:");
    int[,] revertArr = new int[matrix.GetLength(1), matrix.GetLength(0)];
    for (int i = 0; i < revertArr.GetLength(0); i++)
    {
        for (int j = 0; j < revertArr.GetLength(1); j++)
        {
            revertArr[i, j] = matrix[j, i];
        }
    }
    double[] Av = new double[revertArr.GetLength(0)];
    for (int i = 0; i < revertArr.GetLength(0); i++)
    {
        for (int j = 0; j < revertArr.GetLength(1); j++)
        {
            Av[i] += revertArr[i, j];
        }
        Write($"{Math.Round(Av[i] / revertArr.GetLength(1), 2)} ");
    }
}


