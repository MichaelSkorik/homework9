void Print2dMassive(double[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

double[,] Create2dMassive(int rows, int columns, double startValue, double finishValue)
{
    double[,] matrix = new double[rows, columns];
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double randomValue = random.NextDouble() * (finishValue - startValue) + startValue;
            matrix[i, j] = Math.Round(randomValue, 1);
        }
    }
    return matrix;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetInput("Введите количество строк массива: ");
int n = GetInput("Введите количество столбцов массива: ");
double[,] massive = Create2dMassive(m, n, -99, 99);
Print2dMassive(massive);
