using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите число a");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число b");
                int b = Convert.ToInt32(Console.ReadLine());
                if (a == 0 && b == 0)
                {
                    Console.WriteLine("X - любое целое число");
                }
                else if (b % a == 0)
                {
                    Console.WriteLine("Решение: " + b / a);
                }
                else
                {
                    Console.WriteLine("Решения нет");
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: деление на ноль!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введенное значение должно быть целым числом!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: введенное число слишком большое!");
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка!");
            }
        }
    }
}
