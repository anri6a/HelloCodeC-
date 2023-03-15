// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
using static Methods07HW;
public class Task52
{
    public static void ArithmeticMeansOfEachColumn()
    {
        double[,] workArray = CreateArrayRandomeSise();
        FillArrayByIntRandom(workArray);
        PrintArray(workArray);
        Console.WriteLine();
        double[,] newWorkArray = ReverseArray(workArray);
        ArithmeticMeansOfColumn(newWorkArray);

    }
}