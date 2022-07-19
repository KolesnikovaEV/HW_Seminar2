// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

int number = new Random(). Next(1,10000);
Console.WriteLine($"number: {number}");
if(number<100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while(number>999)
    {
        number = number/10;
    }
int FindNumber = number%10;
Console.WriteLine($"Третья цифра: {FindNumber}");
}
