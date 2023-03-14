public class Methods07HW
{
    public static int Input(string text)
    {
        Console.WriteLine(text);
        int number = Convert.ToInt32(Console.ReadLine());
        return number;
    }
    public static double[,] CreateArray(int m, int n)
    {
        return new double[m, n];
    }
    public static void FillDoubleArrayByRandom(double[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = Math.Round((new Random().NextDouble()*2-1)*10,2);
            }
        }
    }
    public static void PrintArray(double[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}