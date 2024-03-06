
using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            int A = 0;
            int B = 0;

            Console.Write("Введите значение A: ");
            A = int.Parse(Console.ReadLine());

            Console.Write("Введите значение B: ");
            B = int.Parse(Console.ReadLine());

            if (A == 0 && B != 0)
            {
                throw new Exception("Решений не существует.");
            }

            if (B % A == 0)
            {
                int x = B / A;
                Console.WriteLine($"Решение уравнения: x = {x}");
            }
            else
            {
                throw new Exception("Решений не существует.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: введите корректное целое число.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ошибка: {e.Message}");
        }
    }
}
