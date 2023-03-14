// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
using static Methods07HW;
public class Task47
{
    public static void FillArrayDoubleRandom()
    {
        int m = Input("Enter m: ");
        int n = Input("Enter n: ");
        double [,] workArray = CreateArray(m, n);
        FillDoubleArrayByRandom(workArray);
        PrintArray(workArray);
    }
}