/*Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот 
день выходным.*/
Console.WriteLine("enter dayNumber");
int dayNumber = Convert.ToInt32(Console.ReadLine());
if (dayNumber <= 7 && dayNumber >= 1)
{
if (dayNumber == 6 || dayNumber == 7)
Console.WriteLine("it is hollyDay");
else
Console.WriteLine("it is workDay");
}
else 
Console.WriteLine("it is wrong dayNumber");


