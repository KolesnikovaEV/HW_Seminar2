// * Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, а на выходе наименования дня
string[]  daysOfWeek= { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
Console.WriteLine("Введите число: ");
int number =  Convert.ToInt32(Console.ReadLine());
if(number < 1 || number > 7)
{
    Console.WriteLine("Такого дня недели не существует");
}
else
{
    Console.WriteLine(daysOfWeek[number-1]);
}
