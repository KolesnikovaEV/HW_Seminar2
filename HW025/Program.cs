// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] Create(int i, int j, int k)
{
    return new int[i, j, k];
}

void Fill(int[,,] array)
{
    int[] unique = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int iuniq = 0;
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                while(true)
                {
                    int newEl = rnd.Next(10,30);
                    if(unique.Contains(newEl) == false)
                    {
                        array[i, j, k] = newEl;
                        unique[iuniq] = newEl;
                        iuniq ++;
                        break;
                    }
                }
            }
        }
    }
}

void Print (int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.WriteLine($"{arr[i, j, k]} ({i}, {j}, {k}) ");
            }
            
        }
    }
}

int[,,] num = Create(2,2,2);
Fill(num);
Print(num);
