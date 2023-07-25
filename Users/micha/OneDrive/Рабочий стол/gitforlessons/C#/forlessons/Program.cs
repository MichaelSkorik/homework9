using System;

class Program
{
    static void Main()
    {
        // Размеры массива
        int rows = 3;
        int columns = 4;

        // Инициализация генератора случайных чисел
        Random random = new Random();

        // Создание и заполнение двумерного массива случайными числами
        int[,] array = new int[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = random.Next(1, 10); // Генерируем случайное число от 1 до 9
            }
        }

        // Вывод созданного массива (для наглядности)
        Console.WriteLine("Сгенерированный массив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Вычисление суммы элементов на главной диагонали и вывод каждого значения
        int sumDiagonal = 0;
        Console.Write("Сумма элементов главной диагонали: ");
        for (int i = 0; i < Math.Min(rows, columns); i++)
        {
            int value = array[i, i];
            sumDiagonal += value;
            Console.Write(value);
        }
        for (int j = 0; j < Math.Min(rows, columns) - 1; j++)
        {

            Console.Write("+");
        }
        
        Console.WriteLine();

       Console.Write("= " + sumDiagonal);
    }
}
