/*Напишите программу, которая принимает на вход три числа и 
выдаёт максимальное из этих чисел.*/
int a = new Random().Next(0, 100);
int b = new Random().Next(0, 100);
int c = new Random().Next(0, 100);
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
if (a > b && a > c)
    Console.WriteLine("maximal " + a);
else 
if (b > a && b > c)
Console.WriteLine("maximal " + b);
else 
if (c > a && c > b)
Console.WriteLine("maximal " + c);
