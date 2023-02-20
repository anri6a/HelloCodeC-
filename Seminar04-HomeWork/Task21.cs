/*Напишите программу, которая принимает на вход координаты двух точек
 и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 
*/
using static Methods;
public class Task21
{
    public static void dotsDifference()
    {
    int [] dot1 = inputDotsCoordinates("enter dot1 coordinates: ");
    int [] dot2 = inputDotsCoordinates("enter dot2 coordinates: ");
    double diffDo1Dot2 = distanceDot1Dot2(dot1, dot2);
    Console.WriteLine($"difference between dots is: {diffDo1Dot2}");
    }
}
