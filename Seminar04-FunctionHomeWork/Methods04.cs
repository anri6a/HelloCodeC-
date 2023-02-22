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
}