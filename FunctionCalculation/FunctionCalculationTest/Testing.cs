using FunctionCalculationLibrary;

Console.WriteLine("Введите количество итераций:");
decimal N = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Введите максимальное значение X:"); 
decimal k = Convert.ToDecimal(Console.ReadLine());
Calculations calculator = new Calculations();
calculator.CalculateFunctionValue(N, k);
