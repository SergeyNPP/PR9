// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
System.Console.WriteLine("Введите коэффициенты");
System.Console.Write("K1 "); int k1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("K2 "); int k2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Произвольная постоянная");
System.Console.Write("B1 "); int b1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("B2 "); int b2 = Convert.ToInt32(Console.ReadLine());

double x =0, c = b2-b1,  d = k1-k2, y = 0;

x = c / d;
y = k1 * x + b1;
Console.WriteLine(" X  Y");
Console.WriteLine($"({x}; {y})");

// Ответ-0.5, -0.5