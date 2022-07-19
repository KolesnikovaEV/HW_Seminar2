// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

int number = new Random(). Next(0,10);
Console.WriteLine(number);
if(number > 7 || number < 1)
{
    Console.WriteLine("Такого дня недели нет");    
}

if(number == 6 || number == 7)
{
   Console.WriteLine("Ура! Выходной!");  
}

if(number < 6 && number > 0)
{
    Console.WriteLine("Будний день. Работай, холоп!"); 
}
