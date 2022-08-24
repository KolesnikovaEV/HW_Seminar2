// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

void Numbers(int m, int n)
{
    int sum = 0;
    while (m <= n) 
    {
        sum = sum + m;
        m++;
    }
    Console.WriteLine($"Сумма: {sum}.");
    
}

int m = 1;
int n = 4;

Numbers(m, n);