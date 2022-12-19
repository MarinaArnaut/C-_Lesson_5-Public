// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] CreateArray()
{
    double[] array = new double[5];
    Console.Write("Массив {");
    for (int i = 0; i < 5; i++)
    {
        array[i] = 100 * Math.Round(new Random().NextDouble(), 3);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("}\n");
    return array;
}

void Diff(double[] NewArray)
{
    int Max = 0;
    int Min = 0;
    for (int i = 1; i < NewArray.Length; i++)
    {
        if (NewArray[i] > NewArray[Max]) Max = i;
        if (NewArray[i] < NewArray[Min]) Min = i;
    }
    Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {Math.Round(NewArray[Max] - NewArray[Min], 2)}");
}
Diff(CreateArray());
