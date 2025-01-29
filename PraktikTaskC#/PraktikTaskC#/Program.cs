using System;

class Program
{
    static void Main()
    {
        Console.Write("Введiть перше число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введiть друге число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double sum = num1 + num2;

        Console.WriteLine($"Сума чисел {num1} i {num2} дорiвнює {sum}");
    }
}