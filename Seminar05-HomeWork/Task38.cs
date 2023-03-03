// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
using static Methods05HW;
public class Task38
{
    public static void DifferenceMinMaxDoubleArrayElements()
    {
        double[] userDoubleArray = CreateDoubleArray(5);
        FillDoubleArrayByRandom(userDoubleArray);
        PrintDoubleArray(userDoubleArray);
        PrintResult(DifferenceMinMaxElements(userDoubleArray), 
        "Difference Max and Min Double Array Elements");
    }
}