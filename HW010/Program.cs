// Задача 27: Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine($"Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int Summa(int c)
{
    int sum = 0;
    while(c != 0)
  {
    int b = c%10;
    sum = sum + b;
    c = c/10;
  }
  return sum;
}

Console.WriteLine($"Сумма чисел: {Summa(a)}");
