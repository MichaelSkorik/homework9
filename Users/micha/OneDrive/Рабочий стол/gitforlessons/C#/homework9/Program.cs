int GetSum(int N)
{
    if (N == 1)
    {
        Console.Write("1");
        return 1;
    }
    else
    {
        Console.Write(N + ",");
    return GetSum(N - 1);
    }
}

int Print(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int N = Print("Enter number");
Console.Write($"Числа от {N} до 0 -> ");
GetSum(N);
