// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

double[] Create(int len)
{
    return new double[len];
}

void Fill(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().NextDouble();
    }
}

void Print(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

double Numbers(double[] array)
{
    int i = 0;
    double max = array[i];
    double min = array[i];
    double diff = 0;
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

double[] num = Create(8);
Fill(num);
Print(num);
Numbers(num);