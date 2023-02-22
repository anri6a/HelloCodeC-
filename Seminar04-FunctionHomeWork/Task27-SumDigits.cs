/*Напишите метод, который принимает на вход число и 
выдаёт сумму цифр в числе.*/
using static Methods04;
public class Task27SumDigits
{
    public static void SumOfDigits()
    {
        int UserNum = inputNumberInt("enter Num");
        int Sum = SumDigits(UserNum);
        Console.WriteLine($"Summ of Digits {UserNum} = {Sum}");
    }
}