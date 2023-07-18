Console.Clear();
Console.WriteLine("Введите число:");
string input = Console.ReadLine();
if (int.TryParse(input, out int number))
{
    int sum = CalculateSumOfDigits(number);
    Console.WriteLine($"Сумма цифр числа {number} равна {sum}");
}
else
{
    Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
}
static int CalculateSumOfDigits(int number)
{
    int sum = 0;
    while (number != 0)
    {
        sum += number % 10;
        number /= 10;
    }
        return sum;
}