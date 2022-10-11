// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53;

Console.Clear();
int[] PointA = new int[3];
int[] PointB = new int[3];
Console.WriteLine("Введите координаты первой точки");
for(int i=0; i<3; i++)
    PointA[i] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
for(int i=0; i<3; i++)
    PointB[i] = Convert.ToInt32(Console.ReadLine()); 
double Distance = Math.Sqrt(Math.Pow(PointA[0]-PointB[0],2)+Math.Pow(PointA[1]-PointB[1],2)+Math.Pow(PointA[2]-PointB[2],2));
        Console.WriteLine($"{Math.Round(Distance,2)}");

