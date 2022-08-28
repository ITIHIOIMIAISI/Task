/* Задача 45: 
Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования. */

int[] RandomArray(int size, int start, int finish)
{
    int[] arr = new int[size];
    for(int i = 0; i<arr.Length; i++)
    {
        arr[i] = new Random().Next(start, finish);
    }
    return arr;
}

int[] CopyArray(int[] array)
{
    int [] arraynew = new int[array.Length];
    for(int i=0; i<array.Length; i++)
    {
        arraynew[i] = array[i];
    }
    return arraynew;
}

int[] array = RandomArray(10, 1, 100);
int[] arraynew = CopyArray(array);

Console.WriteLine(String.Join(",", array));
Console.WriteLine(String.Join(",", arraynew));