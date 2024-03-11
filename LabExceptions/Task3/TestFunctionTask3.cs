using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3Library;


namespace Task3
{
    class TestFunctionTask3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Значение x: от 0 до k (включительно). Введите k");
            int k = Convert.ToInt32(Console.ReadLine()); //последнее значение k в диапазоне
            try
            {
                Calculations.FunctionTask3(k);
            }
            catch (DivideByZeroException) 
            {
                Console.WriteLine("Ошибка: деление на ноль!");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Ошибка: произошел выход за пределы диапазона");
            }
        }
    }
}
