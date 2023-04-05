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
        Console.Write (inputNumber + " ");
        OutputIntNumber(inputNumber-1);
    }
}