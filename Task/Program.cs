/* Задача 44: 
Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */

int Fibonacci(int n)
{
    int resut = 0;
    int resut2 = 1;
    int temp = 0;
    for(int i=1; i < n; i++)
    {
        Console.Write(resut + " ");
        temp = resut2;
        resut2 += resut;
        resut = temp;
    }
    return (resut);
}

void FibonacciSeminar(int n)
{
    int[] arr = new int[n];
    arr[0] = 0;
    arr[1] = 1;
    for(int i=2; i < n; i++)
    {
        arr[i] = arr[i-1]+arr[i-2];
    }
    var str = string.Join(" ", arr);
    Console.WriteLine($"Первые {n} чисел Фабоначчи   {str}");
}



Console.WriteLine("Enter a number");
int n = Convert.ToInt32(Console.ReadLine());
/* Console.WriteLine($"{Fibonacci(n)}"); */
Console.WriteLine($"{Fibonacci(n)}");
FibonacciSeminar(n);