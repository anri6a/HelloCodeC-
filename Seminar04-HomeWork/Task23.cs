/*Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
using static Methods;

public class Task23
{
    public static void cubeNumbersUser()
    {
        int number = inputNumberInt("input number for cube");
        int [] userArray = cubeNumbers(number);
        printArray(userArray);
    }
}