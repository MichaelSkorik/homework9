int rows = new Random().Next(2, 10);
int columns = new Random().Next(2, 10);

int[,] Array = new int[rows, columns];

int[,] CreateArray(int[,] array, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array, int rows, int columns)
{
    Console.WriteLine();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FillSpiralArray(int rows, int columns)
{
    int[,] spiralArray = new int[rows, columns];
    int num = 1;
    int rowStart = 0, rowEnd = rows - 1;
    int colStart = 0, colEnd = columns - 1;

    while (num <= rows * columns)
    {
        for (int i = colStart; i <= colEnd; i++)
        {
            spiralArray[rowStart, i] = num++;
        }
        rowStart++;

        for (int i = rowStart; i <= rowEnd; i++)
        {
            spiralArray[i, colEnd] = num++;
        }
        colEnd--;

        if (rowStart <= rowEnd)
        {
            for (int i = colEnd; i >= colStart; i--)
            {
                spiralArray[rowEnd, i] = num++;
            }
            rowEnd--;
        }

        if (colStart <= colEnd)
        {
            for (int i = rowEnd; i >= rowStart; i--)
            {
                spiralArray[i, colStart] = num++;
            }
            colStart++;
        }
    }
    Console.WriteLine($"Сгенерирован массив [{rows}x{columns}] заполненный спирально !");
    PrintArray(spiralArray, rows, columns);
}

CreateArray(Array, rows, columns);
FillSpiralArray(rows, columns);
