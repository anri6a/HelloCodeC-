// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
using static Methods09HW;
public class Task66
{
    public static void OutputSumIntBetweenMandN()
    {
        int M = InputNumber("Enter M: ");
        int N = InputNumber("Enter N: ");
        Console.WriteLine(OutputSumIntMN(M, N) + " ");
    }

}