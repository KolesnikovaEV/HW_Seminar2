// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число");
int N = Convert.ToInt32(Console.ReadLine());
while(N < 10000 || N > 99999)
{
    Console.WriteLine("Введите пятизначное число");
    N = Convert.ToInt32(Console.ReadLine());
}
int x = N/10000;
int x1 = N%10;
int y = N/1000%10;
int y1 = N/10%10;

if(x==x1 && y==y1)
{
    Console.WriteLine($"Число {N} является палиндромом");
}
else
{
    Console.WriteLine($"Число {N} НЕ является палиндромом");
}