Console.Clear();
int arraySize = new Random().Next(2, 8);
double[] array = new double[arraySize];
int size = 0;
for (int i = 0; i < arraySize; i++)
{
    array[i] = new Random().Next(100, 1000);
}
// Вызываем метод, который найдет разницу между максимальным и минимальным элементами массива
double difference = FindDifference(array);

// Выводим результат на консоль
var str = string.Join(" ", array);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива [{str}] --> {difference}");

double FindDifference(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        else if (array[i] > max)
        {
            max = array[i];
        }
    }

    // Возвращаем разницу между максимальным и минимальным элементами
    return max - min;
}

