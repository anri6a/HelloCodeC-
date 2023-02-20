// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// 1. input number
// 2. convert string to array
// 3. is palindrome?
using static Methods;

public class Task19
{
    public static void Palindrome()
    {
        var input = Console.ReadLine();
        string numberStr = inputNumber("enter number: ");
        int[] userArray = convertStringToArray(numberStr);
        isPalindrome(userArray);
    }
}