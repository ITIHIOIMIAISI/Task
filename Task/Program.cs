/* Задача 43. 
Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем. */ 


Console.Write("k1  ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("b1  ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("k2  ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("b2  ");
double b2 = Convert.ToDouble(Console.ReadLine());
double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;

if ((k1 == k2) && (b1 == b2))
{
        Console.WriteLine("Координаты прямых совпадают"); 
}
else
{
    if ((k1 == k2) || (b1 == b2))
    {
        Console.WriteLine("Координаты прямых паралельны");   
    }
    else
    {
        x = Math.Round(x, 3);
        y = Math.Round(y, 3);
        Console.WriteLine($"Точка пересечения двух прямых: х  ({x});у  ({y})");
    }
}