// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
using static Methods09HW;
public class Task64
{
    public static void OutputAllIntFromN()
    {
        int inputNumber = InputNumber("Enter a number: ");
        OutputIntNumber(inputNumber);
    }
}
