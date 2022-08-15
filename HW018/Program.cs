// Задача 52. Задайте двумерный массив из целых чисел размера NxN. 
// Укажите два числа,означающие строки, которые нужно поменять местами.

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

void Change(int[,] arr, int a, int b)
{
    
    if (a > arr.GetLength(0) || b > arr.GetLength(0)) 
    {
        Console.WriteLine($"Таких строк нет");
    }
    else
    {
        for (int i = 0; i < arr.GetLength(1); i++)
        {
            int t = arr[a - 1, i];
            arr[a - 1, i] = arr[b - 1, i];
            arr[b - 1, i] = t;
        }
        Print(arr);
    }
}

int[,] num = Create(4,3); 
Fill(num);
Print(num);
Console.WriteLine($"Укажите первую строку для замены: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Укажите вторую строку для замены: ");
int b = Convert.ToInt32(Console.ReadLine());
Change(num, a, b);