/*Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.*/
int number = new Random().Next(1, 50);
Console.WriteLine("number = " + number);
for (int i = 1; i < number+1; i++)
if (i % 2 == 0)
    Console.Write(i+" ");


