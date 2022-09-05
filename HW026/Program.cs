// Задача 62. Заполните спирально массив 4 на 4. 

int[,] Create(int i, int j)
{
    return new int[i, j];
}

void Fill(int[,] array)
{
    int number = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = number + 1;
            number++;
        }
        break;
    }

    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 3; j < array.GetLength(1); j++)
        {
            array[i, j] = number + 1;
            number++;
        }
    }

    for (int i = 3; i < array.GetLength(0); i++)
    {
        for (int j = 2; j >= 0; j--)
        {
            array[i, j] = number + 1;
            number++;
        }
        break;
    }

    for (int i = 2; i > 0; i--)
    {
        for (int j = 0; j < 1; j++)
        {
            array[i, j] = number + 1;
            number++;
        }
    }

    for (int i = 1; i < 2; i++)
    {
        for (int j = 1; j < 3; j++)
        {
            array[i, j] = number + 1;
            number++;
        }
    }
    for (int i = 2; i < array.GetLength(0); i++)
    {
        for (int j = 2; j > 0; j--)
        {
            array[i, j] = number + 1;
            number++;
        }
        break;
    }
}

void Print (int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine("\v");
    }
}

int [,] array = Create(4, 4);
Fill(array);
Print(array);