public class Methods05HW
{
    public static int[] CreateArray(int size)
    {
        return new int[size];
    }
    public static void FillArray3DigitsByRandom(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(100, 1000);
        }
    }
    public static void FillArrayAllDigitsByRandom(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(0, 100);
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
    public static int SumNotEvenPositionElements(int[] array)
    {
        int sum = 0;
        for (int i = 1; i < array.Length; i+=2)
        {
            sum += array[i];
        }
        return sum;

    }
    public static void PrintResult(int count, string text)
    {
        Console.WriteLine($" {text} = {count} ");
    }
}