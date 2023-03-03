public class Methods05HW
{
    public static int[] CreateArray(int size)
    {
        return new int[size];
    }
    public static void FillArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(100, 1000);
        }
    }
public static void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
}
    public static int EvenNumbers(int[] array)
    {
        int countEvenNumbers = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0) countEvenNumbers++;
        }
        return countEvenNumbers;
    }
    public static void PrintResult(int count)
    {
        Console.WriteLine($" In Array are {count} even numbers");
    }
}