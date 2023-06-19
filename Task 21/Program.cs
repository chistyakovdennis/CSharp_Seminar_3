// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// int x1 = Coordinate("x", "A");
// int y1 = Coordinate("y", "A");
// int z1 = Coordinate("z", "A");
// int x2 = Coordinate("x", "B");
// int y2 = Coordinate("y", "B");
// int z2 = Coordinate("z", "B");

// int Coordinate(string coorName, string pointName)
// {
//     Console.Write($"Введите координату {coorName} точки {pointName}: ");
//     return Convert.ToInt16(Console.ReadLine());
// }

// double Decision(double x1, double x2, 
//                 double y1, double y2, 
//                 double z1, double z2){
//   return Math.Sqrt(Math.Pow((x2-x1), 2) + 
//                    Math.Pow((y2-y1), 2) + 
//                    Math.Pow((z2-z1), 2));
// }

// double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

// Console.WriteLine($"Длина отрезка: {segmentLength}");

// Второй вариант решения

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите координаты точки A:");
        double x1 = GetCoordinate("x");
        double y1 = GetCoordinate("y");
        double z1 = GetCoordinate("z");

        Console.WriteLine("Введите координаты точки B:");
        double x2 = GetCoordinate("x");
        double y2 = GetCoordinate("y");
        double z2 = GetCoordinate("z");

        double distance = CalculateDistance(x1, y1, z1, x2, y2, z2);
        Console.WriteLine($"Расстояние между точками A и B: {distance:F2}");
    }

    static double GetCoordinate(string coordinateName)
    {
        Console.Write($"Введите координату {coordinateName}: ");
        string input = Console.ReadLine();
        double coordinate;
        while (!double.TryParse(input, out coordinate))
        {
            Console.WriteLine("Неверный формат ввода. Попробуйте снова.");
            Console.Write($"Введите координату {coordinateName}: ");
            input = Console.ReadLine();
        }
        return coordinate;
    }

    static double CalculateDistance(double x1, double y1, double z1, double x2, double y2, double z2)
    {
        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
        return distance;
    }
}