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
                array[i, j] = Math.Round((new Random().NextDouble() * 2 - 1) * 10, 2);
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
    public static double[,] CreateArrayRandomeSise()
    {
        int m = new Random().Next(1, 10);
        int n = new Random().Next(1, 10);
        double[,] array = new double[m, n];
        return array;
    }
    public static void GetNumberFromArrayByPosition(double[,] array, int x, int y)
    {
        double numberFromFindPosition = 0;
        if (x <= array.GetLength(0) && y <= array.GetLength(1))
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    numberFromFindPosition = array[x, y];
                }
            }
            Console.WriteLine("Find Number is:" + numberFromFindPosition);
        }
        else Console.WriteLine("This position not exist!!!");
    }
}