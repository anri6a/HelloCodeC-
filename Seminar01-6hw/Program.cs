/*Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).*/
Console.WriteLine("enter number");
int number = Convert.ToInt16(Console.ReadLine());
if (number % 2 == 0)
Console.WriteLine("number is even");
else 
Console.WriteLine("number is not even");

