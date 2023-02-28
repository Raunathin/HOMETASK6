/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

Console.Clear();

int[] array = GetArray(12, 1, 50);

int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(min, max);
    }
    return result;
}

Console.WriteLine($"В массиве:[{string.Join(",", array)}]");
Console.WriteLine($"Максимальное число: {GetMaxNumber(array)}");
Console.WriteLine($"Минимальное число: {GetMinNumber(array)}");
Console.WriteLine($"Разница между макс. и мин.: {GetMaxNumber(array) - GetMinNumber(array)}");

int GetMaxNumber(int[] InputArray)
{
    int max = int.MinValue;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

int GetMinNumber(int[] InputArray)
{
    int min = int.MaxValue;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}








