// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.



void Numbers(int m, int n)
{
    
    while (m < n) 
    {
        Console.Write($"{m}, ");
        m++;
    }
    Console.WriteLine($"{n}.");
    
}

int m = 4;
int n = 8;

Numbers(m, n);