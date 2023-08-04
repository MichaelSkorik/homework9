



int Ackermann(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return Ackermann(m - 1, 1);
    else if (m > 0 && n > 0)
        return Ackermann(m - 1, Ackermann(m, n - 1));

    throw new ArgumentException("Invalid arguments: m and n must be non-negative integers.");
}



Console.WriteLine("Enter two non-negative integers m and n:");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

int result = Ackermann(m, n);
Console.WriteLine($"Ackermann({m}, {n}) = {result}");
