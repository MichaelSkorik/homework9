int GetSum(int N, int M)
{
    if (N == M)
    {
        return M;
    }
    else
    {
    return N + GetSum(N - 1, M);
    }
}

int Print(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
    return Convert.ToInt32(Console.ReadLine());
}

int N = Print("Введите число N");
int M = Print("Введите число M");
int sum = GetSum(N, M);
Console.Write($"Сумма чисел от {N} до {M} -> {sum}");

