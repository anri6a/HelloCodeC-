public class Methods08HW
{
    public static int Input(string text)
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
    public static int[,] SortArrayByDescendingInString(int[,] array)
    {
        int temp = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1)-1; j++)
                {

                    if (array[i, j] < array[i, j + 1])
                    {
                        temp = array[i, j];
                        array[i, j] = array[i, j + 1];
                        array[i, j + 1] = temp;
                    }

                }
            }
        }
        return array;
    }
    public static void PrintArray(int[,] array)
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