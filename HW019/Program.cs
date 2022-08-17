// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

int[,] Numbers(int[,] array)
{
    
    int temp = 0;
    for ( int i = 0; i < array.GetLength(0); i++ )
    {
        for (int n = 0; n < array.GetLength(1) - 1; n++)
        {
                for (int j = 0; j < array.GetLength(1)-1; j++)
                {
                    if (array[i, j] < array[i, j + 1])
                    {
                        temp = array[i, j];
                        array[i, j] = array[i, j + 1];
                        array[i, j + 1] = temp;
                    }
                    
                }
        }
    }  
    return array;
}

int str = 4;
int column = 4;
int[,] matr = Create(str, column);
Fill(matr);
Print(matr);
Console.WriteLine();
Print(Numbers(matr));





