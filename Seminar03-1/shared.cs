public class Shared
    //1. Создать  
{
    public static int[] CreateArray(int size)
    {
        return new int[size];
    }

    //2. Ввод данных
    public static int Input(string text)
    {
        Console.Write(text + " ");
        return Convert.ToInt32(Console.ReadLine());
    }
    //3. Заполнить 
    public static void FillByUser(int[] array)
    {
        int index = 0;
        while (index < array.Length)
        {
            array[index] = Input("Enter [" + index + "] element: ");
            index++;
        }
    }
    public static void FillByRandom(int[] array)
    {
        int index = 0;
        while (index < array.Length)
        {
            array[index] = new Random().Next(1, 10);
            index++;
        }
    }
    //3. Вывести 
    public static void PrintArray(int[] array)
    {
        int index = 0;
        while (index < array.Length)
        {
            Console.Write(array[index] + " ");
            index++;
        }
        Console.WriteLine();
    }
    //Вывести -N..N
    public static string GetResultMinusNtoN(int N)
    {
        int index = -N;
        string output = string.Empty;
        while (index <= N)
        {
            output = output + index + " ";
            index++;
        }
        return output;
    }
    // 4. Перемешать
    public static void MixArray(int[] array)
    {
        int index = 0;
        int temp = array[index];
        int newIndex = 0;
        while (index < array.Length)
        {
            temp = array[index];
            newIndex = new Random().Next(index, array.Length);
            array[index] = array[newIndex];
            array[newIndex] = temp;
            index++;
        }

    }
    // Найти повторяющиеся элементы
    public static void CountSameElements(int[] array)
    {
        int indexOutside = 0;
        int number = 0;
        int count = 0;
        int indexInside = 0;
        while (indexOutside < array.Length)
        {
            number = array[indexOutside];
            while (indexInside < array.Length)
            {
                if (array[indexInside] == number)
                    count++;
                indexInside++;
            }
            if (count > 1)
            {
                Console.WriteLine(number + " repit " + count + " times");
            }
            indexOutside++;
            indexInside = 0;
            count = 0;
        }
    }
}