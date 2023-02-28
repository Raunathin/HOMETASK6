/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

Console.Clear();

int[] array = GetArray(5, 100, 999);

int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    Random rand = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rand.Next(min, max);
    }
    return result;
}
System.Console.WriteLine($"В массиве [{string.Join(",", array)}]. Кол-во чётных чисел: {ShowEvenNumbers(array)}.");


int ShowEvenNumbers(int[] InputArray)
{
    int count = 0;
    for (int i = 0; i < InputArray.Length; i++)
        if (InputArray[i] % 2 == 0)
            count++;

    return count;
}