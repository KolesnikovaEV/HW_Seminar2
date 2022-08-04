// Задача 29: Напишите метод(ы), которай задаёт массив из 8 элементов и выводит их на экран.

int[] Create(int len)
{
    return new int[len];
}

void Fill(int[] arr)
{
    int i = 0;
    while(i < arr.Length)
    {
        arr[i] = new Random().Next(0,10);
        i++;
    }
}

void Print(int[] numbers)
{
    int index = 0;
    Console.Write($"[ ");
    while(index < numbers.Length-1)
    {
        Console.Write($"{numbers[index],1}, ");
        index++;
    }
    Console.Write($"{numbers[index]}");
    Console.Write($" ]");
    Console.WriteLine();
}

int[] array = Create(8);
Fill(array);
Print(array);