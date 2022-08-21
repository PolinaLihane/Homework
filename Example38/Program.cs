// 38:
// Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.
using static System.Console;
Clear();
int[] array=GetArray(9,-99,100);
WriteLine($"[{String.Join(" ",array)}]");
WriteLine(GetMaxMin(array));

int GetMaxMin(int[] array)
{
    int result2=0;
    int max=array[0];
    int min=array[0];
    for(int i=0;i<array.Length;i++)
    {
        if(array[i]>=max) max=array[i];
        if(array[i]<=min) min=array[i];
    }
    result2=max-min;
    return result2;
}


int[] GetArray(int size,int minValue,int maxValue)
{
    int[] result= new int[size];
    for(int i=0;i<size;i++)
    {
        result[i]=new Random().Next(minValue,maxValue);
    }
    return result;
}
