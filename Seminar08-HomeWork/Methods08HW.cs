public class Methods08HW
{
    public static int Input(string[] text)
    {
        Console.WriteLine(text);
        int number = Convert.ToInt32(Console.ReadLine());
        return number;
    }
    public static int[,] CreateArray(int row, int col)
    {
        int[,] array = new int[row, col];
        return array;
    }
    public static void FillArrayByRandom(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(0, 10);
            }
        }
    }
}