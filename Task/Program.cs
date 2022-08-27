/* Задача 40: 
Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.Теорема о неравенстве 
треугольника: каждая сторона треугольника меньше суммы двух других сторон. */

Console.WriteLine("Введите строну а  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите строну b  ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите строну c  ");
int c = Convert.ToInt32(Console.ReadLine());

bool CheckTriangle(int num1, int num2, int num3)
{
    return num1+num2>num3 && num2+num3>num1 && num1+num3>num2;
}

if(CheckTriangle(a, b, c))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}