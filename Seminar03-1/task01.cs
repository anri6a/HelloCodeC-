// Задача 1
// Реализовать перемешивание массива
using static Shared;
public class task01
{
public static void Ex001Main ()
{
int count = Input("input size of array");
int [] numbers = CreateArray(count);
PrintArray (numbers);
FillByRandom (numbers);
PrintArray (numbers);
FillByUser (numbers);
PrintArray (numbers);
MixArray(numbers);
PrintArray(numbers);
}
}