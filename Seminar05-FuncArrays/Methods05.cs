public class Methods05
{
    public static int [] CreateArray(int size)
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
}