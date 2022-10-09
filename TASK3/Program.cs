//Задача 23

/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.WriteLine("Введите число для создания таблицы кубов предстоящих числел");
double numberN = double.Parse(Console.ReadLine()!);
if (numberN <0)
{
    numberN= -numberN;
}

for( int i =1; i <=numberN; i ++)
{
     double cubeN = Math.Pow(i, 3);
     //int cubeN = numberN*numberN*numberN;
    Console.WriteLine($"Кубом числа {i} является число {cubeN}");

}