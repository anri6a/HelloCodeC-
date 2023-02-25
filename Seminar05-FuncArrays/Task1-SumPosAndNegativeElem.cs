using static Methods05;
public class Task1SumPosAndNegativeElements
{
    public static void GetSumPosAndNegElements()
    {
        int size = GetSizeByUser("Enter Array size");
        int[] UserArray = CreateArray(size);
        FillArray(UserArray);
        PrintArray(UserArray);
        int sumPositive = FindSumPositiveElements(UserArray);
        int sumNegative = FindSumNegativeElements(UserArray);
        PrintResult(sumPositive, sumNegative);
    }
}