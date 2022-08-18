// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов.

int[,] Create(int i, int j)
{
    return new int[i, j];
}

void Fill(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1,100);
        }
    }
}

void Print (int[,] arr)
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

void Summa(int[,] arr)
{
    int sum = 0;
    int min = 1000000;
    int minrow = 1;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
        }
        if (sum < min)
            {
                min = sum;
                minrow = i+1;
            }
    }
    Console.WriteLine($"Номер строки с наименьшей суммой: {minrow} строка. Сумма: {min}");
    
}

int[,] matrix = Create(5, 6);
Fill(matrix);
Print(matrix);
Console.WriteLine();
Summa(matrix);