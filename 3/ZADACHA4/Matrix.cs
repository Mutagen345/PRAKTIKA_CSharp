public class Matrix
{
    private double[,] _numbers;
    private int _rowCount;
    private int _columnCount;
    public int RowCount => _rowCount;
    public int ColumnCount { get { return _columnCount; } }

    public double this[int i, int j]
    {
        get
        {
            if (i >= 0 && i < _rowCount & j >= 0 & j < _columnCount)
            {
                return _numbers[i, j];
            }
            throw new IndexOutOfRangeException();
        }
        set
        {
            if (i >= 0 && i < _rowCount && j >= 0 && j < _columnCount)
            {
                _numbers[i, j] = value;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
    private Matrix() { }
    private Matrix(int rowCount, int columnCount)
    {
        _rowCount = rowCount;
        _columnCount = columnCount;
        _numbers = new double[rowCount, columnCount];
    }
    public static Matrix Generate(int rowCount, int columnCount)
    {
        Matrix matrix = new Matrix(rowCount, columnCount);
        for (int i = 0; i < matrix.RowCount; i++)
        {
            for (int j = 0; j < matrix.ColumnCount; j++)
            {
                matrix[i, j] =Random.Shared.NextDouble() * Random.Shared.Next(3, 20);
            }
        }
        return matrix;
    }

    internal void Substruction(int rowNumber)
    {
        if (rowNumber<0 || rowNumber>=_rowCount)
        {
            throw new IndexOutOfRangeException($"RowNumber is out of {typeof(Matrix)} range");
        }
        for (int i = 0; i < _rowCount; i++)
        {
            if (i == rowNumber)
            {
                continue;
            }
            for (int j = 0; j < _columnCount; j++)
            {
                _numbers[i, j] = _numbers[i, j] - _numbers[rowNumber, j];
            }
        }
    }
}
