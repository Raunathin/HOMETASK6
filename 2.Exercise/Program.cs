/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.Clear();

int[] array = GetArray(12, -20, 20);

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

System.Console.WriteLine($"В массиве [{string.Join(",", array)}]. ");
System.Console.WriteLine($"Сумма эл-ов стоящих на нечётных позициях: {GetSumNumbersNotEvenPos(array)}.");


int GetSumNumbersNotEvenPos(int[] InputArray)
{
    int count = 0;
    for (int i = 1; i < InputArray.Length; i += 2)
    {

        count += InputArray[i];

    }
    return count;
}


//if (a[i] % 2 != 0) a[i] = a[i] * 3;//Если элемент массива нечётный, то умножаем его на 3.
//else a[i] = 0;//Иначе присваиваем значение элементу 0. 


//     }
// int result = 0;
// foreach(int el in InputArray){
//     //result +=el > 0? el:0;
//     if(el > 0){
//         result += el;
//     }
// }
// return result;












