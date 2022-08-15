// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] Create(int i, int j)
{
    return new double[i, j];
}

void Print(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]:f3} ");
        }
       Console.WriteLine(); 
    }
    
}

void Fill(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().NextDouble();
        }
    }
}

double[,] numbers = Create(5, 4);
Fill(numbers);
Print(numbers);