//36
//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
using static System.Console;
Clear();
int[] array=GetArray(9,0,15);
WriteLine($"[{String.Join(",",array)}]");
int sum=GetSum(array);
WriteLine(sum);

int GetSum(int[] array)
{
    int result2=0;
    for(int i=0;i<array.Length;i++)
    if(i%2!=0) result2+=array[i]; 
    return result2;
}

int[] GetArray(int size, int minValue,int maxValue)
{
    int[] result = new int[size];
    for(int i=0;i<size;i++)
    {
        result[i]=new Random().Next(minValue,maxValue);
    }
    return result;
}