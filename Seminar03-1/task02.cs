using static Shared;
public static class task02 
{
    public static void Ex002Main ()
    {
        int numbersCount = Input("enter count of numbers: ");
        int [] array = CreateArray(numbersCount);
        FillByRandom(array);
        PrintArray(array);
        CountSameElements(array);
    }

}