// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] CreateArray()
{
    Console.Write("Введите количество элементов в необходимом массиве: ");
    int num = int.Parse(Console.ReadLine()!);
    Console.Write("Массив { ");
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write($" {array[i]} ");
    }
    Console.WriteLine(" }\n ");
    return array;
}

void Count(int[] NewArray)
{
    int count = 0;
    foreach (int elem in NewArray)
    {
        if (elem % 2 == 0) count++;
    }
    Console.WriteLine($"Четных чисел в массиве: {count}");
}
Count(CreateArray());