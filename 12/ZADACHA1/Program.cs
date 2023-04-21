namespace _12
{
    delegate void DelegatCalculator(); //объявление делегата

    class Program
    {
        static void Main()
        {
            Console.Write("Введите действие (+,-,*,/): ");
            string a = Console.ReadLine();


            switch (a) //условынй оператор
            {
                case "+":
                    DelegatCalculator calcA = new DelegatCalculator(Add); //создание переменной в которой хранится делегат сложения
                    calcA(); //вызов переменной

                    break;
                case "-":
                    DelegatCalculator calcS = new DelegatCalculator(Sub);
                    calcS();

                    break;
                case "*":
                    DelegatCalculator calcM = new DelegatCalculator(Mul);
                    calcM();

                    break;
                case "/":
                    DelegatCalculator calcD = new DelegatCalculator(Div);
                    calcD();

                    break;
                default:
                    Console.WriteLine("Ошибка ввода операции!");
                    break;
            }
            static (int, int) Input() //ввод значений переменных
            {
                Console.Write("Первое число: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Второе число: ");
                int y = Convert.ToInt32(Console.ReadLine());
                return (x, y);
            }
            static void Add()
            {
                (int c, int b) = Input();
                Console.WriteLine("Ответ:{0}", c + b);
            }
            static void Sub()
            {
                (int c, int b) = Input();
                Console.WriteLine("Ответ:{0}", c - b);
            }
            static void Mul()
            {
                (int c, int b) = Input();
                Console.WriteLine("Ответ:{0}", c * b);
            }
            static void Div()
            {
                try
                {
                    (int c, int b) = Input();
                    if (b == 0) throw new DivideByZeroException();
                    Console.WriteLine("Ответ:{0}", c / b);
                }
                catch
                {
                    Console.WriteLine("Деление на ноль!");
                }
            }
        }
    }
}