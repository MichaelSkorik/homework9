//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.WriteLine("Enter first number");
float num1 = float.Parse(Console.ReadLine());
Console.WriteLine("Enter second number");
float num2 = float.Parse(Console.ReadLine());
Console.WriteLine("Enter third number");
float num3 = float.Parse(Console.ReadLine());
float max2 = 0;
if(num1 > num2)
{
    max2 = num1;
}
else
{
    max2 = num2;
}
if(num3 > max2)
{
    Console.WriteLine($"Number {num3} is bigger");
}
else
{
    Console.WriteLine($"Number {max2} is bigger");
}