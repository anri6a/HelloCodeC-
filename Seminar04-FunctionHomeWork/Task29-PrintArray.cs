/*Напишите метод, который задаёт массив из N элементов и
 выводит их на экран.*/
using static Methods04;
public class Task29PrintArray
{
    public static void PrintUserArrayByRange ()
    {
        int ArrayRange = inputNumberInt("input range of array");
        int [] userArray = CreateArray(ArrayRange);
        FillArray(userArray);
        PrintUserArray(userArray);
    }
}