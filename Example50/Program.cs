// 50. 
//Напишите программу, которая на вход принимает позиции элемента 
//в двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет.

using static System.Console;
Clear();

WriteLine("Введите позицию элемента массива n и m");
int n = int.Parse(ReadLine());
int m = int.Parse(ReadLine());
int[,] array = new int[,]
{
{1, 4, 7, 2},

{5, 9, 2, 3},

{8, 4, 2, 4},
};

GetFillArray(array, n, m);

void GetFillArray(int[,] array, int n, int m)
{
    if ((n > array.GetLength(0)) || (m > array.GetLength(1))) WriteLine("Такого элемента нет");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if ((i == n) && (j == m)) WriteLine(array[i, j]);
        }
    }
}
