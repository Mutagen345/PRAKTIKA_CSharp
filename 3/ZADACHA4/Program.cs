class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите размер матрицы (после каждого введённого значения прожимаем Enter)");
        int n = Convert.ToInt32(Console.ReadLine());
        int m = Convert.ToInt32(Console.ReadLine());
        Matrix matrix = Matrix.Generate(n, m);
        Console.WriteLine("Generated matrix");
        PrintMatrix(matrix);
        var isCorectRowNumber=false;
        while (!isCorectRowNumber)
        {
            try
            {
                Console.WriteLine("Введите индекс строки (номер строки - 1)");
                int rowNumber = Convert.ToInt32(Console.ReadLine());

                matrix.Substruction(rowNumber);
                isCorectRowNumber=true;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        Console.WriteLine("Modified matrix");
        PrintMatrix(matrix);
        Console.WriteLine("New matrix");
        Matrix matrix1 = Matrix.Generate(n,m);
        PrintMatrix(matrix1);
        Console.ReadLine();
    }

    private static void PrintMatrix(Matrix matrix)
    {
        for (int i = 0; i < matrix.RowCount; i++)
        {
            for (int j = 0; j < matrix.ColumnCount; j++)
            {
                Console.Write($"{matrix[i,j]:F2} ");
            }
            Console.WriteLine();
        }
    }
}
