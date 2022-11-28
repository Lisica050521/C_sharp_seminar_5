// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int size = 10;
int[] n = new int[size];
FillArrayRandomNumbers(n);
PrintArray(n);

int max = n[0];
int min = n[0];

for (int i = 0; i < n.Length; i++)
{
    if (n[i] > max)
    {
        max = n[i];
    }
    else if (n[i] < min)
    {
        min = n[i];
    }
}

Console.WriteLine($"Минимальное число: {min}");
Console.WriteLine($"Максимальное число: {max}");
Console.WriteLine($"Разница между максимальным и минимальным числами: {max-min}");


void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 555);
    }
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

