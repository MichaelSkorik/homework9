int[,] PrintOld2DMassive(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i,j]} \t");
        }
        Console.WriteLine();
    }
    return massive;
}
void PrintNew2DMassive(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            if(i % 2 == 0 && j % 2 == 0)
            {
                massive[i, j] = massive[i, j] * massive[i, j];
            }
            Console.Write($"{massive[i,j]} \t");
        }
        Console.WriteLine();
    }
}
int[,] Create2DMassive(int rows, int columns,int min, int max)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

int GetInput (string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetInput("Введите количество строк массива: ");
int n = GetInput("Введите количество столбцов массива: ");
int[,] massive = Create2DMassive(m, n, 1, 9);
PrintOld2DMassive(massive);
Console.WriteLine("--------------------------");
PrintNew2DMassive(massive);