using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3Library
{
    public class Calculations
    {
        public static void FunctionTask3(int k)
        {
            int n = 0; //счетчик количества итераций
            for (double x = 0; x <= k; x += 0.1)
            {
                n++;
                double y = 1 / (x - n);
                Console.WriteLine($"Итерация {n}: {y}");
            }
        }
    }    
}
