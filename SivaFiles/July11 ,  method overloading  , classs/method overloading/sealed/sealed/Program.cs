using System;

public sealed class Maths
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }
}

public sealed class Program
{
    public static void Main(string[] args)
    {
        int sum = Maths.Add(5, 3);
        Console.WriteLine("Sum: " + sum);

        int product = Maths.Multiply(4, 6);
        Console.WriteLine("Product: " + product);
    }
}
