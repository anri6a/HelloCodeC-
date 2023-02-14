/*Напишите программу, которая принимает на вход три числа и 
выдаёт максимальное из этих чисел.*/
int a = new Random().Next(1, 100);
int b = new Random().Next(1, 100);
int c = new Random().Next(1, 100);
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


/*int [] array = new int(a, b, c);
int max = 0;
for (int i = 0; i < array.Length; i++)
{
if (array[i] > max)
max = array[i];
}
Console.WriteLine("maximal " + max);*/
