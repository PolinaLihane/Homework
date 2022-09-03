// Задача 60. 
//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

using static System.Console;
using System.Linq;
Clear();
WriteLine("Введите параметры массива: ");
int[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
int[,,] Cube = GetCube(parameters[0], parameters[1], parameters[2]);
PrintCube(Cube);

int[,,] GetCube(int rows, int colums, int width)
{
    int[,,] result = new int[rows, colums,width];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            for (int k = 0; k < width; k++)
            {         
            result[i, j,k] = new Random().Next(1, 10); 
            }
        }
    }
    return result;
}

void PrintCube(int[,,] inCube)
{
    for (int i = 0; i < inCube.GetLength(0); i++)
    {
        for (int j = 0; j < inCube.GetLength(1); j++)
        {
         for (int k = 0; k < inCube.GetLength(2); k++)
        {
            Write($"{inCube[i, j,k]}({i},{j},{k}) ");
        }
         WriteLine();
        }
    }
}

//bool GetCheck(int[,,] Cube) // не смогла прикрутить проверку
//{
 //   for (int i = 0; i < result.GetLength(0); i++)
  //  {
  //      for (int j = 0; j < result.GetLength(1); j++)
 //       {
  //       for (int k = 0; k < result.GetLength(2); k++)
  //      {
  //           if(Cube[i,j,k]!= newCube)  return true;
   //     }
  //      }
  //  }
  //   return false;
//}