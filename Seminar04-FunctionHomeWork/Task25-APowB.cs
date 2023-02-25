/*Напишите метод, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
Math.Pow использовать нельзя
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
using static Methods04;
public class Task25APowB
{
    public static void APowB2()
    {
        int A = InputNumber("enter A");
        int B = InputNumber("enter B");
        int Result = ResultAPowB(A, B);
        PrintApowB(Result);
    }
    
}