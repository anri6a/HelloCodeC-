// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного 
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
using static Methods08HW;
public class Task54
{
    int row = Input("Enter number of rows: ");
    int col = Input("Enter number of columns: ");
    int [,] workArray = CreateArray(row, col);
    FillArrayByRandom();
}