// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] Create(int length)
{
    return new int[length];
}

void Fill(int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        array[i] = new Random(). Next(99, 1000);
    }
}

void Print(int[] array)
{
    for(int i=0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int Chetnii(int[] arr)
{

    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
    if (arr[i]%2==0)
    {
        count++;
    }
    }
    return count;
    
}

int[] numerals = Create(8);
Fill(numerals);
Print(numerals);
Console.WriteLine(Chetnii(numerals));