// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей 
// суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка
using static Methods08HW;
public class Task56
{
    public static void StringWithMinimalSumElements()
    {
        int row = Input("Enter row number: ");
        int column = Input("Enter column number: ");
        int [, ] workArray = CreateArray(row, column);
        FillArrayByRandom(workArray);
        PrintArray(workArray);
        MinimalSumElementsInString(workArray);
    }
}
