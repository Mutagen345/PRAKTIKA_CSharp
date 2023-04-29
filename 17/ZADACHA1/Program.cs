using GeometryLibrary;

// создание объекта треугольника
Triangle triangle = new Triangle(3, 4, 5);


    // вычисление периметра иругольника
    double Perimeter = triangle.Perimeter();

    // вычисление площади треугольника
    double Area = triangle.Area();

    // определение типа треугольника
    string type = triangle.Type();


// создание объекта прямоугольника
Rectangle rectangle = new Rectangle(2, 3);

// вычисление периметра прямоугольника
double perimeter = rectangle.Perimeter();

// вычисление площади прямоугольника
double area = rectangle.Area();

Console.WriteLine(Perimeter);
Console.WriteLine(Area);
Console.WriteLine(type);
Console.WriteLine(perimeter);
Console.WriteLine(area);