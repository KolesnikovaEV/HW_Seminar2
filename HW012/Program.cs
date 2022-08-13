// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] Create(int len)
{
    return new int[len];
}

void Fill(int[] array)
{
    for (int i = 0; i<array.Length; i++)
    {
        array[i] = new Random(). Next(0,1000);
    }
}

void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int Summa(int[] numerals)
{
    int sum = 0;
    for (int i = 0; i < numerals.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum+numerals[i];
        }
    }
    return sum;
}

int[] num = Create(20);
Fill(num);
Print(num);
Console.WriteLine(Summa(num));