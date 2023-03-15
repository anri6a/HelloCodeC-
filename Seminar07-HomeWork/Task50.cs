// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет
using static Methods07HW;
public class Task50
{
    public static void GetNumberFromArrayByInputPosition()
    {
        int row = Input("Enter row number: ");
        int col = Input("Enter column number: ");
        Console.WriteLine($"Find position: [{row}, {col}]");
        double[,] workArray = CreateArrayRandomeSise();
        Console.WriteLine($"In array: [{workArray.GetLength(0)}, {workArray.GetLength(1)}]");
        FillDoubleArrayByRandom(workArray);
        GetNumberFromArrayByPosition(workArray, row, col);
    }
}