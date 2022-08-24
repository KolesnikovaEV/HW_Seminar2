// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

void SummaNumbers(int m, int n)
{
    int sum = 0;
    while (m <= n) 
    {
        sum = sum + m;
        m++;
    }
    Console.WriteLine($"Сумма чисел: {sum}.");
    
}

int m = 1;
int n = 4;

SummaNumbers(m, n);