// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
using static Methods05HW;
public class Task34
{
    public static void CountEvenNumbers()
    {
        int[] userArray = CreateArray(10);
        FillArray(userArray);
        PrintArray(userArray);
        int result = EvenNumbers(userArray);
        PrintResult(result);
    }
}