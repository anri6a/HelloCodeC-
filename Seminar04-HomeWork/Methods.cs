using System;
public class Methods
{
    public static string inputNumber(string text)
    {
        Console.WriteLine(text);
        string numberString = Console.ReadLine();
        return numberString;
    }
    public static int[] convertStringToArray(string numberString)
    {
        int[] array = new int[numberString.Length];
        for (int i = 0; i < numberString.Length; i++)
        {
            array[i] = int.Parse(numberString[i] + "");
            Console.Write(array[i] + " ");
        }
        return array;
    }
    public static void isPalindrome(int[] userArray)
    {
        int count = 0;
        for (int i = 0; i < userArray.Length / 2; i++)
        {
            if (userArray[i] == userArray[userArray.Length - i - 1])
            {
                count++;
            }
            else
                break;
        }
        if (count == userArray.Length / 2)
            Console.WriteLine("Palindrome");
        else
            Console.WriteLine("Not Palindrome");

    }
    public static int[] inputDotsCoordinates(string text)
    {
        int[] coordinatesArray = new int[3];
        Console.WriteLine(text);
        for (int i = 0; i < 3; i++)
        {
            coordinatesArray[i] = Convert.ToInt32(Console.ReadLine());
        }
        return coordinatesArray;
    }
    public static double distanceDot1Dot2(int[] dot1, int[] dot2)
    {
        double[] diff = new double[3];
        for (int i = 0; i < dot1.Length; i++)
        {
            diff[i] = Math.Pow((dot1[i] - dot2[i]), 2);
        }
        double difference = Math.Sqrt(diff[0] + diff[1] + diff[2]);
        return difference;
    }
    public static int[] cubeNumbers(int number)
    {
        int[] resultArray = new int[number];
        for (int i = 0; i < number; i++)
        {
            resultArray[i] = Convert.ToInt32(Math.Pow(i + 1, 3));
        }
        return resultArray;
    }
    public static void printArray(int[] resultArray)
    {
        for (int i = 0; i < resultArray.Length; i++)
            Console.Write(resultArray[i] + " ");
    }
    public static int inputNumberInt(string text)
    {
        Console.WriteLine(text);
        int number = Convert.ToInt32(Console.ReadLine());
        return number;
    }
}