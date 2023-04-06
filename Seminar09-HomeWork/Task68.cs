// ** Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
using static Methods09HW;
public class Task68
{
    public static void AckermanFunction()
    {
        int m = InputNumber("Enter first number: ");
        int n = InputNumber("Enter second number: ");
        Console.WriteLine(AckFunc(m, n));
    }
}