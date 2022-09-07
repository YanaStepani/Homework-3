/* Напишите программу, которая принимает на вход координаты двух точек и находит 
расстояние между ними в 3D пространстве. A (3,6,8); B (2,1,-7), -> 15.84,  A (7,-5, 0); B (1,-1,9) -> 11.53
*/

// Определение функции нахождения расстояния между точками в 3D:
double GetDistanceTwoPoint3D(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return distance;
}

// запрос данных у пользователя:
Console.WriteLine("Введите координаты первой точки:");
Console.Write("Введите x1: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Введите y1: ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("Введите z1: ");
double z1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки:");
Console.Write("Введите x2: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Введите y2: ");
double y2 = double.Parse(Console.ReadLine());
Console.Write("Введите z2: ");
double z2 = double.Parse(Console.ReadLine());

// вызов функции и выведение ответа пользователю:
double result = GetDistanceTwoPoint3D(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между точками ({x1}, {y1}, {z1}) и ({x2}, {y2}, {z2}) = " + Math.Round(result,2));
