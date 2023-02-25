public class Methods04
{
    public static int InputNumber(string text)
    {
        Console.WriteLine(text);
        int number = Convert.ToInt32(Console.ReadLine());
        return number;
    }
    public static int ResultAPowB(int A, int B)
    {
        int ResultAPowB = A;
        for (int i = 1; i < B; i++)
        {
            ResultAPowB = ResultAPowB * A;
        }
        return ResultAPowB;
    }
    public static void PrintApowB(int res)
    {
        Console.WriteLine("A Pow B = " + res);
    }
    public static int SumDigits(int UserNumber)
    {
        int sum = 0;
        while (UserNumber > 0)
        {
            sum = sum + UserNumber % 10;
            UserNumber = UserNumber / 10;
        }
        return sum;
    }
    public static int inputNumberInt(string text)
    {
        Console.WriteLine(text);
        int number = Convert.ToInt32(Console.ReadLine());
        return number;
    }

    public static int [] CreateArray(int size)
{
    return new int[size]; 
}
    public static int [] FillArray(int [] userArray)
{
    for (int i = 0; i < userArray.Length; i++)
    userArray[i] = new Random().Next(0, 100);
    return userArray;
}
    public static void PrintUserArray(int [] userArray)
    {
        for (int i = 0; i < userArray.Length; i++)
        Console.Write(userArray[i] + " ");
    }
}