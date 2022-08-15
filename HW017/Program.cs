// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] Create(int i, int j)
{
    return new int[i, j];
}

void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
       Console.WriteLine(); 
    }
    
}

void Fill(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0, 100);
        }
    }
}

void Position(int[,] arr, int i, int j)
{
    if (i > arr.GetLength(0) || j > arr.GetLength(1))
    {
        Console.WriteLine($"Такого числа в массиве нет");
    }
    else
    {
    Console.WriteLine($"Число: {arr[i-1, j-1]}");
    }
}

int[,] numbers = Create(3,3);
Fill(numbers);
Print(numbers);
Console.WriteLine($"Введите номер строки:");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите номер столбца:");
int j = Convert.ToInt32(Console.ReadLine());
Position(numbers, i, j);