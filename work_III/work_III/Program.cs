using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            try
            {
                Console.Write("Введите первое число: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Введите второе число: ");
                int num2 = int.Parse(Console.ReadLine());

                if (num2 == 0)
                {
                    throw new DivideByZeroException("Деление на ноль невозможно.");
                }

                Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введите корректное целое число.");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Продолжаем выполнение программы...");
            }
        }
    }
}
