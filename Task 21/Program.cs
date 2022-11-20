// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите координаты точки A в виде трех чисел X/Y/Z");
int xOnePoint = Convert.ToInt32(Console.ReadLine());
int yOnePoint = Convert.ToInt32(Console.ReadLine());
int zOnePoint = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки В в виде трех чисел X/Y/Z");
int xTwoPoint = Convert.ToInt32(Console.ReadLine());
int yTwoPoint = Convert.ToInt32(Console.ReadLine());
int zTwoPoint = Convert.ToInt32(Console.ReadLine());

double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return length;
}

double proximity = Distance(xOnePoint, yOnePoint, zOnePoint, xTwoPoint, yTwoPoint, zTwoPoint);
Console.WriteLine($"Расстояние между точками А и В равно {Math.Round(proximity, 2, MidpointRounding.ToZero)}");