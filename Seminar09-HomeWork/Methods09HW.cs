public class Methods09HW
{
    public static int InputNumber(string text)
    {
        Console.WriteLine(text);
        int inputNumber;
        return inputNumber = Convert.ToInt32(Console.ReadLine());
    }
    public static void OutputIntNumber(int inputNumber)
    {
        if (inputNumber < 1) return;
        Console.Write(inputNumber + " ");
        OutputIntNumber(inputNumber - 1);
    }
    public static int OutputSumIntMN(int M, int N)
    {
        if (M > N) return 0;
        return M + OutputSumIntMN(M + 1, N);
    }
    public static int AckFunc(int m, int n)
    {
        if (m == 0) return (n + 1);
        else if ((m != 0) && (n == 0)) return AckFunc(m - 1, 1);
        else return AckFunc(m - 1, AckFunc(m, n - 1));
    }
}