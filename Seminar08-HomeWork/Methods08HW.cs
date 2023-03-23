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
                for (int j = 0; j < array.GetLength(1) - 1; j++)
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
    public static void MinimalSumElementsInString(int[,] array)
    {
        int stringNumber = -1;
        int[] sumArray = new int[array.GetLength(0)];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum = sum + array[i, j];
            }
            sumArray[i] = sum;
        }
        int minSum = int.MaxValue;
        for (int i = 0; i < sumArray.Length; i++)
        {
            if (minSum > sumArray[i])
            {
                minSum = sumArray[i];
                stringNumber = i;
            }
        }
        Console.WriteLine("String with minimal summ elements is : " + stringNumber);
    }
    public static bool IsPosibleMiltiplicateArrays(int[,] array1, int[,] array2)
    {
        bool posible = false;
        if (array1.GetLength(0) == array2.GetLength(1)) posible = true;
        return posible;
    }
    public static int[,] MultiplicationArrays(int[,] array1, int[,] array2)
    {
        int[,] resultArray = new int[array1.GetLength(0), array2.GetLength(1)];
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                for (int k = 0; k < array1.GetLength(1); k++)
                {
                    resultArray[i, j] += array1[i, k] * array2[k, j];
                }
            }
        }
        return resultArray;
    }
}