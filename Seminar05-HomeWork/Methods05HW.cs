public class Methods05HW
{
    public static int[] CreateArray(int size)
    {
        return new int[size];
    }
    public static double[] CreateDoubleArray(int size)
    {
        return new double[size];
    }
    public static void FillDoubleArrayByRandom(double[] array)
    {
        for (int i = 0; i < array.Length; i++)
            array[i] = new Random().Next(-10, 10)/100.0;
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
    public static void PrintDoubleArray(double[] array)
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
        for (int i = 1; i < array.Length; i += 2)
        {
            sum += array[i];
        }
        return sum;

    }
    public static double DifferenceMinMaxElements(double[] array)
    {
        double max = array[0];
        double min = array[1];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max) max = array[i]; 
            else if (array[i] < min) min = array[i];
        }
        return (max - min);
    }
    public static void PrintResult(double count, string text)
    {
        Console.WriteLine($" {text} = {count} ");
    }
}