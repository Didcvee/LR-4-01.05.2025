using System;
using System.Numerics;

namespace HelloWorldApp;

public class Program
{
    private static int SumDigits(BigInteger number)
    {
        int sum = 0;
        while (number > 0)
        {
            sum += (int)(number % 10);
            number /= 10;
        }
        return sum;
    }

    public static void Main(string[] args)
    {
        Console.Write("Введите основание степени: ");
        int baseNumber = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Введите показатель степени: ");
        int exponent = int.Parse(Console.ReadLine() ?? "0");
        
        BigInteger powerResult = BigInteger.Pow(baseNumber, exponent);
        int digitSum = SumDigits(powerResult);
        
        Console.WriteLine($"Сумма цифр числа {baseNumber}^{exponent} ({powerResult}) = {digitSum}");
    }
}
