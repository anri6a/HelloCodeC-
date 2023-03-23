// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
using static Methods08HW;
public class Task58
{
    public static void MatrixMultiplication()
    {
        int rowArray1 = Input("Input row numbers in 1st array: ");
        int columnArray1 = Input("Input column numbers in 1st array: ");
        int rowArray2 = Input("Input row numbers in 2nd array: ");
        int columnArray2 = Input("Input column numbers in 2nd array: ");
        int [, ] workArray1 = new int[rowArray1, columnArray1];
        int [, ] workArray2 = new int[rowArray2, columnArray2];
        FillArrayByRandom(workArray1);
        FillArrayByRandom(workArray2);
        PrintArray(workArray1);
        Console.WriteLine();
        PrintArray(workArray2);
        Console.WriteLine();
        if (IsPosibleMiltiplicateArrays(workArray1, workArray2) == true)
        {
            PrintArray(MultiplicationArrays(workArray1, workArray2));
        }
        else Console.WriteLine("It is not possible to Multiplicate Arrays");

    }
}