/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33] */

int[] InitArray(int demension)
{
    int[] array = new int[demension];
    Random rnd = new Random();
    for (int i = 0; i < demension; i++)
    {
        array[i] = rnd.Next(0, 100);
    }
    return array;
}

/* void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
     Console.Write("]");
    Console.WriteLine();
}
 */
int[] array = InitArray(8);

//только такой вариант нашел изображения массива без последней запятой
var result = string.Join(", ", array);
Console.WriteLine($"[{result}]");


/* PrintArray(array); */
