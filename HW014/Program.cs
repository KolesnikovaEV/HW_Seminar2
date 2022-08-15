// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.


int Count(string s)
{
    
    int[] numbers = s.Split(',').Select(snum => int.Parse(snum)).Take(6).ToArray();
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0) count++;
    }
    Console.WriteLine($"Чисел больше нуля: {count}");
    return count;
}

Console.WriteLine($"Введите числа через запятую:");
string s = Console.ReadLine();
Count(s);
