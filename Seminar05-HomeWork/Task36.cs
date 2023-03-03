// Задача 36: Задайте одномерный массив, заполненный случайными 
// числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
using static Methods05HW;
public class Task36
{
    public static void SumNotEvenElements()
    {
        int[] userArray = CreateArray(5);
        FillArrayAllDigitsByRandom(userArray);
        PrintArray(userArray);
        PrintResult(SumNotEvenPositionElements(userArray), 
        "Summ Numbers Not Even Position Elements");
    }
}
