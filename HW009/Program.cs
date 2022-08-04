// Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine($"Введите число A:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите число B:");
int b = Convert.ToInt32(Console.ReadLine());


double Stepen(int a, int b)
{
   double c = Math.Pow(a, b);
   return c;
}

Console.WriteLine(Stepen(a, b));