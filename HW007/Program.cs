// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
double[] Create(int len)
{
    return new double[len];
}
void Fill(double[] numbers)
{
    int index = 0;
    while(index<numbers.Length)
    {
        numbers[index] = new Random().Next(-10,11);
        index++;
    }
}
void Print(double[] array)
{
    int len = array.Length;
    int i = 0;
    while(i<len)
    {
        Console.Write($"{array[i],4}");
        i++;
    }
    Console.WriteLine();
}

double[] B = Create(3);
double[] C = Create(3);
Fill(B);
Fill(C);
Print(B);
Print(C);
double x12 = Math.Pow((C[0]-B[0]),2);
double y12 = Math.Pow((C[1]-B[1]),2);
double z12 = Math.Pow((C[2]-B[2]),2);
double Distance = Math.Sqrt(x12 + y12 + z12);
Console.WriteLine(Distance);
