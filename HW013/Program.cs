// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

int[] Create(int len)
{
    return new int[len];
}

void Fill(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random(). Next(0,300);
    }
}

void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int Numbers(int[] array)
{
    int i = 0;
    int max = array[i];
    int min = array[i];
    int diff = 0;
    for (;i < array.Length; i++)
    {
        if (max < array[i]) 
        {
            max = array[i];
        }   
        else if (min > array[i]) 
        {
            min = array[i];
        }
    }
    diff = max - min;
    Console.WriteLine($"Максимальное число: {max}, минимальное число: {min}. Разница: {diff}");
    return diff;
    
}

int[] num = Create(8);
Fill(num);
Print(num);
Numbers(num);