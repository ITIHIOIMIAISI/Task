/* Задача 41: 
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. */

float GetNumbersAboveZero(float sum)
{
    int count = 0;
    for(int i=0; i<sum; i++)
    {
        Console.WriteLine("Enter a digit");
        float number = (Convert.ToInt32(Console.ReadLine()));
            if (number>0)
            {
                count++;
            }
    }
    return(count);
}

Console.WriteLine("Enter a nubmer");
float sum = (Convert.ToInt32(Console.ReadLine()));
Console.WriteLine($"the Quantity of numbers above 0 {GetNumbersAboveZero(sum)}");