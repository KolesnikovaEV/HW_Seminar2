// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

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
            array[i, j] = new Random().Next(1,10);
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

int[,] Mult(int[,] matr1, int[,] matr2)
{
    if(matr1.GetLength(1) != matr2.GetLength(0))
    {
        Console.WriteLine("Ошибка! Перемножение невозможно!");
        return new int[0,0];
    }
    else
    {
        int[,] res = new int[matr1.GetLength(0), matr2.GetLength(1)];
        for (int i = 0; i < matr1.GetLength(0); i++)
        {
            for (int j = 0; j < matr2.GetLength(1); j++)
            {
                res[i, j] = 0;
                for(int k = 0; k < matr2.GetLength(0); k++)
                {
                    res[i, j] = res[i, j] + matr1[i, k] * matr2[k, j];
                }
            }
        }
        return res;
    }
}

int[,] matr1 = Create(3, 2);
int[,] matr2 = Create(2, 3);
Fill(matr1);
Fill(matr2);
Print(matr1);
Console.WriteLine();
Print(matr2);
Console.WriteLine();
Print(Mult(matr1, matr2));