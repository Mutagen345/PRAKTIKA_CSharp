namespace Geometry
{
    class Program
    {
        delegate void GeometryDelegate();

        static void Main(string[] args)
        {
            // Создаётся экземпляр делегата
            GeometryDelegate geometryDelegate = new GeometryDelegate(CalculateGeometry);

            // Вызываются все методы с помощью делегата
            geometryDelegate.Invoke();

            Console.ReadKey();
        }

        static void CalculateGeometry()
        {
            try
            {
                // Вычисление периметра и площади квадрата
                int side = 5;
                int perimeter = 4 * side;
                int area = side * side;

                Console.WriteLine($"Квадрат со стороной {side} имеет периметр {perimeter} и площадь {area}");

                // Вычисляется сторона треугольника
                int hypotenuse = 10;
                int leg = 6;
                int sideTriangle = (int)Math.Sqrt(hypotenuse * hypotenuse - leg * leg);

                Console.WriteLine($"Треугольник с гипотенузой {hypotenuse} и катет {leg} его сторона {sideTriangle}");
            }
            catch (Exception e)
            {
                // Регистрируется и обрабатывается исключение
                Console.WriteLine($"Ошибка: {e.Message}");
            }
        }
    }
}
