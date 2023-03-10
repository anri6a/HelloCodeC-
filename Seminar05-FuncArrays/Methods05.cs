public class Methods05
{
    public static int GetSizeByUser(string message)
    {
        System.Console.WriteLine(message);
        int size = Convert.ToInt32(Console.ReadLine());
        return size;
    }
    public static int[] CreateArray(int size)
    {
        return new int[size];
    }
    public static void FillArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(-9, 9);
        }
    }
    public static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
    public static int FindSumPositiveElements(int[] array)
    {
        int sumPositive = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
                sumPositive += array[i];
        }
        return sumPositive;
    }
    public static int FindSumNegativeElements(int[] array)
    {
        int sumNegative = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
                sumNegative += array[i];
        }
        return sumNegative;
    }
    public static void PrintResult(int sumPositive, int sumNegative)
    {
        Console.WriteLine($"Sum Positive elements is {sumPositive} and Negative is {sumNegative}");
    }
}