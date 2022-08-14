// 21
//Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

using static System.Console;
Clear();

WriteLine("Введите координаты первой точки");
int x1 = int.Parse(ReadLine());
int y1 = int.Parse(ReadLine());
int z1 = int.Parse(ReadLine());

WriteLine("Введите координаты второй точки");
int x2 = int.Parse(ReadLine());
int y2 = int.Parse(ReadLine());
int z2 = int.Parse(ReadLine());

double Distance = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
WriteLine($"Растояние между двух точек = {Distance:f2}");