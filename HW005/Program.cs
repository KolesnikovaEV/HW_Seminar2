// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int N = new Random().Next(1,20);
Console.WriteLine($"N = {N}");
int count = 1;
int stepen = 3;
while(count <= N)
{
    Console.WriteLine($"{count}^3 = {Math.Pow(count, stepen)}");
    count++;
}

