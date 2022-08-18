// 25
//Напишите цикл, который принимает на вход два числа (A и B) и
// возводит число A в натуральную степень B.

using static System.Console;
Clear();

WriteLine("Введите А и В");
int A = int.Parse(ReadLine());
int B = int.Parse(ReadLine());
WriteLine(GetDegree(A,B));

int GetDegree(int A, int B)
{
    int result = 1;
    for (int i=0;i<B;i++)
    {
        result = result*A;
    }
    return result;
}