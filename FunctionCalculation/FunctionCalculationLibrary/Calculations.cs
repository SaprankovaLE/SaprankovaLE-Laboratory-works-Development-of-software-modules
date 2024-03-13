using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionCalculationLibrary
{
    public class Calculations
    {
        public decimal CalculateFunctionValue(decimal N, decimal k)
        {
            decimal result = 0;

            for (int i = 0; i < N; i++)
            {
                decimal x = i * 0.1m;
                try
                {
                    while (x <= k && x >= 0)
                    {
                        result = 1 / (x - N);
                        break;
                    }
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine($"Деление на 0 при x = {x}");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"Выход за пределы диапазона при x = {x}");
                }
                finally
                {
                    Console.WriteLine($"При x = {x} результат: {result}");
                }
            }
            Console.WriteLine(result);
            return result;
        }
    }
}
