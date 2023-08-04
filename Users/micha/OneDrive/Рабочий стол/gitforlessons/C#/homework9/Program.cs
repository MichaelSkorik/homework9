int GetFactorial(int N)
{
    if (N == 1)
        return 1;
    
    return N * GetFactorial(N - 1);
}

int Print(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int N = Print("Enter number");
int factorial = GetFactorial(N);
Console.WriteLine($"Factorial of {N} is: {factorial}");