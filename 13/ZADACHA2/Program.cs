using System;

namespace Geometry
{
    class Program
    {
        // Определение делегата
        delegate void GeometryDelegate(int a);

        static void Main(string[] args)
        {
            // Создание экземпляра делегата
            GeometryDelegate del = new GeometryDelegate(CalculateArea);

            // Вызов делегата с разными аргументами
            del(5);
            del(10);
            del(15);

            // Вызов метода с делегатом в качестве параметра
            UseDelegate(del);
        }

        // Метод вычисления периметра квадрата
        static void CalculatePerimeter(int side)
        {
            int perimeter = 4 * side;
            Console.WriteLine($"Периметр квадрата со стороной {side} равна {perimeter}");
        }

        // Метод вычисления площади квадрата
        static void CalculateArea(int side)
        {
            int area = side * side;
            Console.WriteLine($"Площадь квадрата со стороной {side} равна {area}");
        }

        // Метод чтобы напечатать длину стороны треугольника
        static void PrintTriangleSide(int side)
        {
            Console.WriteLine($"Длина стороны треугольника равна {side}");
        }

        // Метод использования делегата в качестве параметра
        static void UseDelegate(GeometryDelegate del)
        {
            del(20);
        }
    }
}
